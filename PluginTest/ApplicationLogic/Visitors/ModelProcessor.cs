using ApplicationLogic.Enums;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using OpenModelsLibrary.Interfaces;
using OpenModelsLibrary.Models;
using System;
using System.Linq;

namespace ApplicationLogic.Visitors
{
    public class ModelProcessor : IVisitor
    {
        private readonly ICrudLogic<Product> productLogic;
        private readonly ICrudLogic<Supply> supplyLogic;

        public ModelProcessor(ICrudLogic<Product> productLogic, 
            ICrudLogic<Supply> supplyLogic)
        {
            this.productLogic = productLogic;
            this.supplyLogic = supplyLogic;
        }

        public void Process(ProductOpenModel productOpen)
        {
            if (!string.IsNullOrWhiteSpace(productOpen.Name))
            {
                Product product = productLogic.Read(new Product
                {
                    Name = productOpen.Name
                }).FirstOrDefault();
                if (product != null)
                {
                    product.Unit = (MeasureUnit)Enum.Parse(typeof(MeasureUnit),
                        productOpen.Unit.ToString());
                };
                productLogic.Update(product);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void Process(SupplyOpenModel supplyOpen)
        {
            if (supplyOpen.Count <= 0)
            {
                throw new ArgumentException("Количество поставляемых " +
                    "продуктов должно быть больше 0");
            }
            if (supplyOpen.Product == null)
            {
                throw new ArgumentException("В поставке не был указан продукт");
            }
            supplyLogic.Create(new Supply
            {
                Product = productLogic.Read(new Product
                { Name = supplyOpen.Product.Name }).First(),
                Count = supplyOpen.Count,
                Date = DateTime.Now
            });
        }
    }
}
