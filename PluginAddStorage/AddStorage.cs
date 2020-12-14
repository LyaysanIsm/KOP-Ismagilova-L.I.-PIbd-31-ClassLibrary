using ClassLibraryPlugins.Interfaces;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginAddStorage
{
    [Export(typeof(IAdd<Product>))]
    public class AddStorage : IAdd<Product>
    {
        public string Name => "Пополнение склада";
        public void AddToStorage(Product obj, int value)
        {
            obj.Count += value;
        }
    }
}