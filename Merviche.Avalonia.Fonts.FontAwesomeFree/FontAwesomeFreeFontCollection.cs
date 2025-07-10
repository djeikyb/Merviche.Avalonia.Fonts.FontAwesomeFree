using Avalonia.Media.Fonts;

namespace Merviche.Avalonia.Fonts.FontAwesomeFree;

public sealed class FontAwesomeFreeRegularFontCollection : EmbeddedFontCollection
{
    public FontAwesomeFreeRegularFontCollection() : base(
        new Uri("fonts:far", UriKind.Absolute),
        new Uri("avares://Merviche.Avalonia.Fonts.FontAwesomeFree/Assets/Regular", UriKind.Absolute))
    {
    }
}

public sealed class FontAwesomeFreeSolidFontCollection : EmbeddedFontCollection
{
    public FontAwesomeFreeSolidFontCollection() : base(
        new Uri("fonts:fas", UriKind.Absolute),
        new Uri("avares://Merviche.Avalonia.Fonts.FontAwesomeFree/Assets/Solid", UriKind.Absolute))
    {
    }
}

public sealed class FontAwesomeFreeBrandsFontCollection : EmbeddedFontCollection
{
    public FontAwesomeFreeBrandsFontCollection() : base(
        new Uri("fonts:fab", UriKind.Absolute),
        new Uri("avares://Merviche.Avalonia.Fonts.FontAwesomeFree/Assets/Brands", UriKind.Absolute))
    {
    }
}