using DataAccessLayer.BindingModels;
using DataAccessLayer.Interfaces;
using DataAccessLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System;
using DataAccessLayer.DatabaseModels;

namespace DataAccessLayer.CrudLogic
{
    public class ProductCrudLogic : ICrudLogic<ProductBindingModel, ProductViewModel>
    {
        private readonly DatabaseContext context;

        public ProductCrudLogic(DatabaseContext context)
        {
            this.context = context;
        }

        public void Create(ProductBindingModel newItem)
        {
            if (context.Products.Any(product => 
            product.Name == newItem.Name))
            {
                throw new Exception("Продукт уже существует в бд");
            }
            context.Products.Add(new Product
            {
                Name = newItem.Name,
                Unit = newItem.Unit,
                DateOfSupply = newItem.DateOfSupply
            });
            context.SaveChanges();
        }

        public void Delete(ProductBindingModel item)
        {
            if (!item.Id.HasValue)
            {
                throw new ArgumentNullException();
            }
            Product oldItem = context.Products.FirstOrDefault(product =>
            product.Id == item.Id.Value);
            if (oldItem == null)
            {
                throw new Exception("Продукт не найден в бд");
            }
            context.Products.Remove(oldItem);
            context.SaveChanges();
        }

        public IEnumerable<ProductViewModel> Read(ProductBindingModel conditions)
        {
            return context.Products.Where(product => (conditions == null) ||
            (conditions.Id.HasValue && conditions.Id.Value == product.Id)).Select(product =>
            new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                DateOfSupply = product.DateOfSupply.ToShortDateString(),
                Unit = product.Unit.ToString()

            }).ToList();
        }

        public void Update(ProductBindingModel item)
        {
            if (!item.Id.HasValue)
            {
                throw new ArgumentNullException();
            }
            if (context.Products.Any(product => product.Name == item.Name))
            {
                throw new Exception("Продукт с таким именем уже есть в бд");
            }
            Product oldItem = context.Products.FirstOrDefault(product =>
            product.Id == item.Id.Value);
            if (oldItem == null)
            {
                throw new Exception("Продукт не найден в бд");
            }
            oldItem.DateOfSupply = item.DateOfSupply;
            oldItem.Unit = item.Unit;
            oldItem.Name = item.Name;
            context.SaveChanges();
        }
    }
}
