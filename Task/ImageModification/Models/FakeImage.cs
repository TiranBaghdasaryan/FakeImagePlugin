using ImageModification.Plugins;

namespace ImageModification.Models;

public class FakeImage
{
    public int size;
    public int blurPercentage;
    
    public FakeImage(int size, int blurPercentage)
    {
        size = size;
        blurPercentage = blurPercentage;

        Console.WriteLine($"Log: created image with size :{size}, and blur percentage {blurPercentage}.");
    }
}