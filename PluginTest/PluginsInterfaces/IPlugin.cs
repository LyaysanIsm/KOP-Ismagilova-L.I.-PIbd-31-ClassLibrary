using System;

namespace PluginsInterfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        Action ActionDone { get; set; }
        void Activate();
    }
}