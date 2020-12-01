using ApplicationLogic.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ApplicationLogic.DataStorage
{
    public class FileStorage
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        private readonly string productsFile = @"Data/products.xml";
        private readonly string ordersFile = @"Data/orders.xml";

        public FileStorage()
        {
            LoadOrders();
            LoadProducts();
        }

        ~FileStorage()
        {
            SaveOrders();
            SaveProducts();
        }

        private void LoadOrders()
        {
            if (File.Exists(ordersFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(ordersFile, FileMode.Open))
                {
                    Orders = (List<Order>)serializer.Deserialize(fs);
                }
            }
            else
            {
                Orders = new List<Order>();
            }
        }

        private void SaveOrders()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(ordersFile, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, Orders);
            }
        }

        private void LoadProducts()
        {
            if (File.Exists(productsFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using (FileStream fs = new FileStream(productsFile, FileMode.Open))
                {
                    Products = (List<Product>)serializer.Deserialize(fs);
                }
            }
            else
            {
                Products = new List<Product>();
            }
        }

        private void SaveProducts()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream(productsFile, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, Products);
            }
        }
    }
}
