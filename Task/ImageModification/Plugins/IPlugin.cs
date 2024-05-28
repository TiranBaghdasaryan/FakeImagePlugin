using ImageModification.Models;

namespace ImageModification.Plugins;

public interface IPlugin
{
    /// <summary>
    /// Execute plugin.
    /// </summary>
    /// <param name="image"></param>
    void Execute(FakeImage image);
}