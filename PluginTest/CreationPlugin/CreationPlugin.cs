using OpenModelsLibrary.Models;
using PluginsInterfaces;
using System;
using System.Collections.Generic;

namespace CreationPlugin
{
    public class CreationPlugin : IPlugin
    {
        public string Name { get; set; }

        public string Version { get; set; }

        public IPluginHost Host { get; set; } 

        private SupplyOpenModel Supply { get; set; }

        public CreationPlugin()
        {
            Name = "Плагин для обработки поступления продукта";
            Version = "1.0";
            Supply = new SupplyOpenModel();
        }

        public void Activate()
        {
            CreationForm creationForm = new CreationForm(this);
            creationForm.Show();
        }

        private bool PluginIsRegistered()
        {
            return Host != null;
        }

        protected internal void SetProduct(ProductOpenModel product)
        {
            if (product != null)
            {
                Supply.Product = product;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        protected internal void SetCount(string count)
        {
            if (int.TryParse(count, out int result))
            {
                Supply.Count = result;
            }
            else
            {
                throw new Exception("Неверный формат числа продуктов");
            }
        }

        protected internal List<string> GetProductData()
        {
            if (Supply.Product != null)
            {
                return new List<string> {
                    $"Название: {Supply.Product.Name}",
                    $"Единица измерения: {Supply.Product.Unit}",
                    $"Цена: {Supply.Product.Price}"
                };
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        protected internal void SubmitData()
        {
            if (PluginIsRegistered())
            {
                Host.ProcessResult(Supply);
            }
            else
            {
                throw new Exception("Плагин не зарегистрирован");
            }
        }
    }
}
