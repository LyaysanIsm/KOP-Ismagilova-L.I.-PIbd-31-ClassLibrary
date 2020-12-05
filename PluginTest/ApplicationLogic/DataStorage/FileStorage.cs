using ApplicationLogic.Models;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace ApplicationLogic.DataStorage
{
    public class FileStorage
    {
        public List<Product> Products { get; set; }
        public List<Supply> Supplies { get; set; }
        public List<Plugin> Plugins { get; set; }

        private readonly string productsFile = @"Data/products.xml";
        private readonly string suppliesFile = @"Data/supplies.xml";

        public FileStorage()
        {
            LoadSupplies();
            LoadProducts();
            LoadPlugins();
        }

        ~FileStorage()
        {
            SaveSupplies();
            SaveProducts();
        }

        private void LoadPlugins()
        {
            Plugins = new List<Plugin>();
            string applicationPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string[] pluginFiles = Directory.GetFiles(applicationPath, "*Plugin.dll");
            foreach (string pluginFile in pluginFiles)
            {
                Plugins.Add(new Plugin { Path = pluginFile });
            }
        }

        private void LoadSupplies()
        {
            if (File.Exists(suppliesFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Supply>));
                using (FileStream fs = new FileStream(suppliesFile, FileMode.Open))
                {
                    Supplies = (List<Supply>)serializer.Deserialize(fs);
                }
            }
            else
            {
                Supplies = new List<Supply>();
            }
        }

        private void SaveSupplies()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Supply>));
            using (FileStream fs = new FileStream(suppliesFile, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, Supplies);
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
