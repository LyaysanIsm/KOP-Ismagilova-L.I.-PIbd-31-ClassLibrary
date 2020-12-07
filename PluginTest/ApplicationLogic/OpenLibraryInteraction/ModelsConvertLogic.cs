using ApplicationLogic.Models;
using OpenModelsLibrary.Enums;
using OpenModelsLibrary.Models;
using System;

namespace ApplicationLogic.OpenLibraryInteraction
{
    public static class ModelsConvertLogic
    {
        public static ProductOpenModel GetOpenProduct(Product product)
        {
            return new ProductOpenModel
            {
                Name = product.Name,
                Price = product.Price,
                Unit = (MeasureUnitOpenEnum)Enum
                .Parse(typeof(MeasureUnitOpenEnum),
                product.Unit.ToString())
            };
        }

        public static SupplyOpenModel GetOpenSupply(Supply supply)
        {
            return new SupplyOpenModel
            {
                Product = new ProductOpenModel
                {
                    Name = supply.Product.Name,
                    Price = supply.Product.Price,
                    Unit = (MeasureUnitOpenEnum)Enum.Parse(typeof(MeasureUnitOpenEnum),
                    supply.Product.Unit.ToString())
                },
                Date = supply.Date
            };
        }
    }
}
