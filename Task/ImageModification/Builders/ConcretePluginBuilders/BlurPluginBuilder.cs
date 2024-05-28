using ImageModification.Plugins;

namespace ImageModification.Builders.ConcretePluginBuilders;

public class BlurPluginBuilder : IPluginBuilder
{
    private BlurImage _blurImage = new BlurImage();
    public BlurPluginBuilder WithPercentage(int percentage)
    {
        if (percentage < 0 || percentage > 100) throw new ArgumentException();
        _blurImage.blurPercentage = percentage;
        
        return this;
    }
    
    public IPlugin Build() => _blurImage;
}