using ClassLibraryPlugins.Interfaces;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPlugins
{
    public class PluginManager
    {
        [ImportMany(typeof(IChange<Product, Category>))]
        IEnumerable<IChange<Product, Category>> Changers { get; set; }

        [ImportMany(typeof(IAdd<Product>))]
        IEnumerable<IAdd<Product>> Adds { get; set; }

        [ImportMany(typeof(IWaybill<Product>))]
        IEnumerable<IWaybill<Product>> Waybills { get; set; }

        public readonly Dictionary<string, Action<Product, Category>> ChangersDict = new Dictionary<string, Action<Product, Category>>();
        public readonly Dictionary<string, Action<Product, int>> AddsDict = new Dictionary<string, Action<Product, int>>();
        public readonly Dictionary<string, Action<Product>> WaybillsDict = new Dictionary<string, Action<Product>>();

        public List<string> Headers { get; set; } = new List<string>();

        public PluginManager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));

            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            if (Changers.Count() != 0)
            {
                Changers.ToList().ForEach(p =>
                {
                    ChangersDict.Add(p.Name, p.Change);
                    Headers.Add(p.Name);
                });
            }

            if (Adds.Count() != 0)
            {
                Adds.ToList().ForEach(s =>
                {
                    AddsDict.Add(s.Name, s.AddToStorage);
                    Headers.Add(s.Name);
                });
            }

            if (Waybills.Count() != 0)
            {
                Waybills.ToList().ForEach(s =>
                {
                    WaybillsDict.Add(s.Name, s.Create);
                    Headers.Add(s.Name);
                });
            }

        }
    }
}