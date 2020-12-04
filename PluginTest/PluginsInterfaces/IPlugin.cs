namespace PluginsInterfaces
{
    public interface IPlugin
    {
        string Name { get; }
        string Version { get; }
        bool Activate<T>(T obj);
    }
}