using PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
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

        public Action ActionDone { get; set; }

        protected internal Type EnumType { get; private set; }
        protected internal object TargetObject { get; set; }

        public ChangerPlugin()
        {
            Name = "Плагин для изменения значения перечисления";
            Version = "1.0";
        }

        public void Activate()
        {
            //TargetObjectType = typeof(T);
            var pluginForm = new ChangerForm(this);
            pluginForm.Show();
        }


        protected internal void UpdateObject(string enumValue)
        {
            var props = TargetObject.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType == EnumType)
                {
                    prop.SetValue(TargetObject, Enum.Parse(EnumType, enumValue));
                    ActionDone?.Invoke();
                    return;
                }
            }
        }

        private void SetEnumType()
        {
            PropertyInfo[] props = TargetObject.GetType().GetProperties();
            foreach (var prop in props)
            {
                if (prop.PropertyType.IsEnum)
                {
                    EnumType = prop.PropertyType;
                    return;
                }
            }
            throw new Exception("Тип переданного объекта не содержит enum-свойств");
        }

        protected internal List<string> GetEnumValues()
        {
            SetEnumType();
            List<string> enumValues = new List<string>();
            foreach (var enumValue in Enum.GetValues(EnumType))
            {
                enumValues.Add(enumValue.ToString());
            }
            return enumValues;
        }
    }
}
