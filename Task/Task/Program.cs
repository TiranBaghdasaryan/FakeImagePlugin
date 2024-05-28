using ImageModification.Builders.ConcretePluginBuilders;
using ImageModification.Extensions;
using ImageModification.Models;

// Create concrete plugin "Resize"
var resizePluginBuilder = new ResizePluginBuilder();
resizePluginBuilder.WithSize(100);
var resizePlugin = resizePluginBuilder.Build();

// Create concrete plugin "Blur"
var blurPluginBuilder = new BlurPluginBuilder();
blurPluginBuilder.WithPercentage(5);
var blurPlugin = blurPluginBuilder.Build();

// Create new fake image
var image = new FakeImage(size: 150, blurPercentage: 0);

// Apply plugins to image
image.ApplyEffects(blurPlugin, resizePlugin);

// Remove plugins if exists.
image.RemoveEffects(blurPlugin);


Console.ReadKey();