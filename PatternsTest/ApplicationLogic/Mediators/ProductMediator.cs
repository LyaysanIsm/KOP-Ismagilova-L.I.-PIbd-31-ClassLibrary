using ApplicationLogic.Abstract;
using ApplicationLogic.BindingModels;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Managers;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;

namespace ApplicationLogic.Mediators
{
    public class ProductMediator : IMediator
    {
        private readonly ClientManager clientManager;
        private readonly DeliveryManager deliveryManager;
        private readonly  WarehouseManager warehouseManager;

        public event Action<string> Status;

        public ProductMediator(List<Warehouse> warehouses)
        {
            clientManager = new ClientManager(this);
            warehouseManager = new WarehouseManager(this, warehouses);
            deliveryManager = new DeliveryManager(this);
        }

        public void Notify(object message, Manager manager)
        {
            if (!(message is DeliveryDataBindingModel))
            {
                throw new ArgumentException();
            }
            if (manager == clientManager)
            {
                Status?.Invoke("Выполняется поиск по складам...");
                warehouseManager.SearchAsync(message as DeliveryDataBindingModel);
            }
            if (manager == warehouseManager)
            {
                if (!string.IsNullOrWhiteSpace((message as DeliveryDataBindingModel).WarehouseName))
                {
                    Status?.Invoke("Соединение со службой доставки...");
                    deliveryManager.OrderAsync(message as DeliveryDataBindingModel);
                }
                else
                {
                    Status?.Invoke("Извините, товара " +
                        $"{(message as DeliveryDataBindingModel).ProductName} нет в наличии");
                }
            }
            if (manager == deliveryManager)
            {
                Status?.Invoke((message as DeliveryDataBindingModel).DeliveryDetails);
            }
        }

        public void OrderDelivery(DeliveryDataBindingModel model)
        {
            clientManager.OrderDelivery(model);
        }
    }
}
