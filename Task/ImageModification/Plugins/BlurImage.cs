using ImageModification.Models;

namespace ImageModification.Plugins;

public class BlurImage : IPlugin
{
    public int blurPercentage = 0;
    public void Execute(FakeImage image)
    {
        image.blurPercentage = blurPercentage;
    }
}