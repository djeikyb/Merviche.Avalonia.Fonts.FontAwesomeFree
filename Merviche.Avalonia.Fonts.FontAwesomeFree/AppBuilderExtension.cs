using Avalonia;

namespace Merviche.Avalonia.Fonts.FontAwesomeFree;

public static class AppBuilderExtension
{
    public static AppBuilder WithFontAwesomeFree(this AppBuilder appBuilder)
    {
        return appBuilder.ConfigureFonts(fontManager =>
        {
            fontManager.AddFontCollection(new FontAwesomeFreeRegularFontCollection());
            fontManager.AddFontCollection(new FontAwesomeFreeSolidFontCollection());
            fontManager.AddFontCollection(new FontAwesomeFreeBrandsFontCollection());
        });
    }
}