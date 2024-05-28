using ImageModification.Models;

namespace ImageModification.Plugins;

public class ResizeImage : IPlugin
{
    public int size;
    private int? previousSize;
    
    public void Execute(FakeImage image)
    {
        previousSize = image.size;
        image.size = size;
    }

    public void Rollback(FakeImage image)
    {
        if (!previousSize.HasValue) return;
        image.size = previousSize.Value;
    }
}