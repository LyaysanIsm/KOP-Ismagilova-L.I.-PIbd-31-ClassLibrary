using OpenModelsLibrary.Enums;
using OpenModelsLibrary.Models;
using PluginsInterfaces;
using System;
using System.Collections.Generic;

namespace ChangerPlugin
{
    public class ChangerPlugin : IPlugin
    {
        private string name;
        private string version;

        public string Name {
            get { return name; }
            private set { name = value; }
        }

        public string Version {
            get { return version; }
            private set { version = value; }
        }

        protected internal ProductOpenModel Product { get; set; } 

        public IPluginHost Host { get; set; }

        public ChangerPlugin()
        {
            Name = "Плагин для изменения значения перечисления";
            Version = "1.0";
        }

        public void Activate()
        {
            var pluginForm = new ChangerForm(this);
            pluginForm.Show();
        }


        protected internal void UpdateObject(string enumValue)
        {
            Product.Unit = (MeasureUnitOpenEnum)Enum.Parse(typeof(MeasureUnitOpenEnum), enumValue);
            if (PluginIsRegistered())
            {
                Host.ProcessResult(Product);
            }
            else
            {
                throw new Exception("Плагин не зарегистрирован");
            }
        }

        private bool PluginIsRegistered()
        {
            return Host != null;
        }

        protected internal List<string> GetEnumValues()
        {
            List<string> enumValues = new List<string>();
            foreach (var enumValue in Enum.GetValues(Product.Unit.GetType()))
            {
                enumValues.Add(enumValue.ToString());
            }
            return enumValues;
        }
    }
}
