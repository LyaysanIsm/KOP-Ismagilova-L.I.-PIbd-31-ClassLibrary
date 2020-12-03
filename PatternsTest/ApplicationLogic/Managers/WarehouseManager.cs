using ApplicationLogic.Abstract;
using ApplicationLogic.BindingModels;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationLogic.Managers
{
    public class WarehouseManager : Manager
    {
        private readonly List<Warehouse> warehouses;

        public WarehouseManager(IMediator mediator, List<Warehouse> warehouses) 
            : base(mediator)
        {
            this.warehouses = warehouses;
        }

        public async void SearchAsync(DeliveryDataBindingModel model)
        {
            await Task.Run(() => SearchProduct(model));
            mediator.Notify(model, this);
        }

        public void SearchProduct(DeliveryDataBindingModel model)
        {
            Thread.Sleep(4000);
            foreach (var warehouse in warehouses)
            {
                if (warehouse.Products.Any(product =>
                product.Name == model.ProductName))
                {
                    model.WarehouseName = warehouse.Name;
                    break;
                }
            }
        }
    }
}
