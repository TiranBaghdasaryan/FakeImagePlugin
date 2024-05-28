using ImageModification.Plugins;

namespace ImageModification.Builders.ConcretePluginBuilders;

public class ResizePluginBuilder : IPluginBuilder
{
    private ResizeImage _resizeImage = new ResizeImage();
    public ResizePluginBuilder WithSize(int size)
    {
        _resizeImage.size = size;
        
        return this;
    }

    public IPlugin Build() => _resizeImage;
}