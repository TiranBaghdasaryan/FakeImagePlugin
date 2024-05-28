using ImageModification.Models;
using ImageModification.Plugins;

namespace ImageModification.Extensions;

public static class FakeImageExtensions
{
    public static void ApplyEffects(this FakeImage image, params IPlugin[] plugins)
    {
        foreach (var plugin in plugins)
        {
            plugin.Execute(image);
        }

        Console.WriteLine($"Log: modified image size: {image.size} and blur percentage {image.blurPercentage}");
    }
    
    public static void RemoveEffects(this FakeImage image, params IPlugin[] plugins)
    {
        foreach (var plugin in plugins)
        {
            plugin.Rollback(image);
        }

        Console.WriteLine($"Log: modified image size: {image.size} and blur percentage {image.blurPercentage}");
    }
}