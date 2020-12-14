using ClassLibraryPlugins.Interfaces;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChange
{
    [Export(typeof(IChange<Product, Category>))]
    public class ChangeCategory : IChange<Product, Category>
    {
        public string Name => "Изменение категории продуктов";
        public void Change(Product obj, Category value)
        {
            obj.Category = value;
        }
    }
}