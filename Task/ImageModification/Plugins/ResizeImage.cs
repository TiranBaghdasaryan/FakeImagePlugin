using ImageModification.Models;

namespace ImageModification.Plugins;

public class ResizeImage : IPlugin
{
    public int size;
    public void Execute(FakeImage image)
    {
        image.size = size;
    }
}