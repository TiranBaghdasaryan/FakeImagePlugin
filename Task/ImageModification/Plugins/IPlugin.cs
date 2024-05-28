using ImageModification.Models;

namespace ImageModification.Plugins;

public interface IPlugin
{
    /// <summary>
    /// Execute plugin.
    /// </summary>
    /// <param name="image"></param>
    void Execute(FakeImage image);
    
    /// <summary>
    /// Rollback previous state
    /// </summary>
    /// <param name="image"></param>
    void Rollback(FakeImage image);
}