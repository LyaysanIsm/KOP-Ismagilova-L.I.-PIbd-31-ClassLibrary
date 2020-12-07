using ApplicationLogic.DataStorage;
using ApplicationLogic.Models;
using PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ApplicationLogic.DataAccessLogic
{
    public class PluginLogic
    {
        private readonly FileStorage storage;

        public PluginLogic(FileStorage storage)
        {
            this.storage = storage;
        }

        public List<IPlugin> GetPlugins()
        {
            List<IPlugin> loadedPlugins = new List<IPlugin>();
            List<Plugin> plugins = storage.Plugins;
            foreach (Plugin plugin in plugins)
            {
                Assembly assembly = Assembly.LoadFrom(plugin.Path);
                if (assembly != null)
                {
                    var types = assembly.GetTypes();
                    foreach (var type in types)
                    {
                        try
                        {
                            var instance = Activator.CreateInstance(type);
                            if (instance is IPlugin)
                            {
                                loadedPlugins.Add(instance as IPlugin);
                            }

                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
            return loadedPlugins;
        }
    }
}
