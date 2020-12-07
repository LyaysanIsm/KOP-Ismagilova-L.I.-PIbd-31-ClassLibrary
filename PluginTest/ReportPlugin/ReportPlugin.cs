using OpenModelsLibrary.Models;
using PluginsInterfaces;
using ReportPlugin.Models;
using System;
using System.Collections.Generic;

namespace ReportPlugin
{
    public class ReportPlugin : IPlugin
    {
        public string Name { get; set; }

        public string Version { get; set; }

        public IPluginHost Host { get; set; }

        private SupplyOpenModel Supply { get; set; }
        private PrintData PrintData { get; set; }

        public ReportPlugin()
        {
            Supply = new SupplyOpenModel();
            PrintData = new PrintData();
            Name = "Плагин для печати накладной по поставке";
            Version = "1.0";
        }

        public void Activate()
        {
            ReportForm reportForm = new ReportForm(this);
            reportForm.Show();
        }

        protected internal void SetSupply(SupplyOpenModel supply)
        {
            if (supply == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Supply = supply;
                PrintData.ProductName = supply.Product.Name;
                PrintData.ProductUnit = supply.Product.Unit.ToString();
                PrintData.DateOfSupply = supply.Date.ToString();
            }
        }

        protected internal List<string> GetSupplyData()
        {
            if (Supply == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return new List<string>()
                {
                    $"Дата поставки: {Supply.Date}",
                    $"Название продукта: {Supply.Product.Name}",
                    $"Единица измерения: {Supply.Product.Unit}"
                };
            }
        }

        protected internal void SetInvoiceNumber(string number)
        {
            if (int.TryParse(number, out int result))
            {
                PrintData.InvoiceNumber = $"#{result}";
            }
            else
            {
                throw new ArgumentException("Неверный формат номера накладной");
            }
        }

        protected internal void SetCustomerName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                PrintData.CustomerName = name;
            }
            else
            {
                throw new Exception("Имя заказчика не заполнено");
            }
        }

        protected internal void SetCustomerAddress(string address)
        {
            if (!string.IsNullOrWhiteSpace(address))
            {
                PrintData.CustomerAddress = address;
            }
            else
            {
                throw new Exception("Адрес заказчика не заполнен");
            }
        }

        internal PrintData GetPrintData()
        {
            return PrintData;
        }
    }
}
