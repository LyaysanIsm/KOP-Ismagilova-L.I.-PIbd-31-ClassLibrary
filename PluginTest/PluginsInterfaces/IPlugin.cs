namespace PluginsInterfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        IPluginHost Host { get; set; }
        void Activate();
    }
}