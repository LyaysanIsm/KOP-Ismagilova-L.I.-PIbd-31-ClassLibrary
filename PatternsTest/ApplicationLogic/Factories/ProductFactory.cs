using ApplicationLogic.Models;

namespace ApplicationLogic.Factories
{
    public class ProductFactory
    {
        private readonly Product apple = new Product 
        {
            Manufacturer = new Company { Name = "Apple", Country = "USA" } 
        };
        private readonly Product samsung = new Product
        {
            Manufacturer = new Company { Name = "Samsung", Country = "Republic of Korea" }
        };
        private readonly Product xiaomi = new Product
        {
            Manufacturer = new Company { Name = "Xiaomi", Country = "China" }
        };

        private Product GetSmartphone(string name, int price, Product product)
        {
            Product smartphone = (Product) product.Clone();
            smartphone.Name = name;
            smartphone.Price = price;
            return smartphone;
        }

        public Product GetAppleSmartphone(string name, int price)
        {
            return GetSmartphone(name, price, apple);
        }

        public Product GetSamsungSmartphone(string name, int price)
        {
            return GetSmartphone(name, price, samsung);
        }

        public Product GetXiaomiSmartphone(string name, int price)
        {
            return GetSmartphone(name, price, xiaomi);
        }
    }
}
