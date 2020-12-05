using ApplicationLogic.DataStorage;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationLogic.DataAccessLogic
{
    public class ProductLogic : ICrudLogic<Product>
    {
        private readonly FileStorage storage;

        public ProductLogic(FileStorage storage)
        {
            this.storage = storage;
        }

        public void Create(Product model)
        {
            Product existingProduct = storage.Products.FirstOrDefault(product =>
            product.Name == model.Name);
            if (existingProduct != null)
            {
                throw new Exception("Такой продукт уже есть в бд");
            }
            storage.Products.Add(model);
        }

        public void Delete(Product model)
        {
            Product toDelete = storage.Products.FirstOrDefault(product =>
            product.Name == model.Name);
            if (toDelete == null)
            {
                throw new Exception("Продукт не найден в бд");
            }
            storage.Products.Remove(toDelete);
        }

        public List<Product> Read(Product model)
        {
            return storage.Products.Where(product => model == null ||
            product.Name == model.Name).ToList();
        }

        public void Update(Product model)
        {
            Product toUpdate = storage.Products.FirstOrDefault(product =>
            product.Name == model.Name);
            if (toUpdate == null)
            {
                throw new Exception("Продукт не найден в бд");
            }
            toUpdate = model;
        }
    }
}
