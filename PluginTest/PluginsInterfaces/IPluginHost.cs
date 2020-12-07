namespace PluginsInterfaces
{
    public interface IPluginHost
    {
        void ProcessResult(object result);
        void RegisterPlugin(IPlugin plugin);
    }
}
