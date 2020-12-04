using PluginsInterfaces;
using System;
using System.Windows.Forms;

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

        public ChangerPlugin()
        {
            Name = "Плагин для изменения значения перечисления";
            Version = "1.0";
        }

        public bool Activate<T>(T obj)
        {
            DataBindingModel model = new DataBindingModel
            {
                Type = GetEnumType(typeof(T))
            };
            var pluginForm = new ChangerForm(this, model);
            if (pluginForm.ShowDialog() == DialogResult.OK)
            {
                UpdateObject(obj, model);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateObject<T>(T obj, DataBindingModel model)
        {
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType == model.Type)
                {
                    prop.SetValue(obj, Enum.Parse(model.Type, model.ChosenElement));
                }
            }
        }

        private Type GetEnumType(Type type)
        {
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType.IsEnum)
                {
                    return prop.PropertyType;
                }
            }
            return null;
        }
    }
}
