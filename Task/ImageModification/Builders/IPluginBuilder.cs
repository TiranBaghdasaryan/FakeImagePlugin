using ImageModification.Plugins;

namespace ImageModification.Builders;

public interface IPluginBuilder
{
    public IPlugin Build();
}