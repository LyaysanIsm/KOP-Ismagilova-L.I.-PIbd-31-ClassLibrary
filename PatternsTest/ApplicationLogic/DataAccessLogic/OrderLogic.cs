using ApplicationLogic.DataStorage;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System.Collections.Generic;

namespace ApplicationLogic.DataAccessLogic
{
    public class OrderLogic : ICrudLogic<Order>
    {
        private readonly FileStorage storage;

        public OrderLogic(FileStorage storage)
        {
            this.storage = storage;
        }

        public void Create(Order model)
        {
            storage.Orders.Add(model);
        }

        public void Delete(Order model)
        {
        }

        public List<Order> Read(Order model)
        {
            return storage.Orders;
        }

        public void Update(Order model)
        {
        }
    }
}
