using ApplicationLogic.DataStorage;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;

namespace ApplicationLogic.DataAccessLogic
{
    public class WarehouseLogic : ICrudLogic<Warehouse>
    {
        private readonly FileStorage storage;

        public WarehouseLogic(FileStorage storage)
        {
            this.storage = storage;
        }

        public void Create(Warehouse model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Warehouse model)
        {
            throw new NotImplementedException();
        }

        public List<Warehouse> Read(Warehouse model)
        {
            List<Product> products = storage.Products;
            products.RemoveAt(1);
            products.RemoveAt(2);
            return new List<Warehouse>
            {
                new Warehouse
                {
                    Name = "Главный склад",
                    Products = products
                }
            };
        }

        public void Update(Warehouse model)
        {
            throw new NotImplementedException();
        }
    }
}
