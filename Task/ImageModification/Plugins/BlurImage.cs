using ImageModification.Models;

namespace ImageModification.Plugins;

public class BlurImage : IPlugin
{
    public int blurPercentage = 0;
    private int? previousBlurPercentage;
    
    public void Execute(FakeImage image)
    {
        previousBlurPercentage = image.blurPercentage;
        image.blurPercentage = blurPercentage;
    }

    public void Rollback(FakeImage image)
    {
        if (!previousBlurPercentage.HasValue) return;
        image.blurPercentage = previousBlurPercentage.Value;
    }
}