namespace FoxHoleWebAPI;
public static class MapData
{
    public static (double X, double Y) WorldExtentMinimum = (-109199.999997, -94499.99999580906968410989);
    public static (double X, double Y) WorldExtentMaximum = (109199.999997, 94499.99999580906968410989);

    public static MapIconColours ColonialMapColours = new()
    {
        Colour = (0.082283, 0.14996, 0.07036, 1.0),
        RGB = (21, 38, 18, 255),
        HexLinear = 0x152612FF,
        HexSRGB = 0x516C4BFF
    };

    public static MapIconColours WardenMapColours = new()
    {
        Colour = (0.017642, 0.093059, 0.223228, 1.0),
        RGB = (4, 23, 57, 255),
        HexLinear = 0x041739FF,
        HexSRGB = 0x245682FF
    };
}

public class MapIconColours
{
    internal MapIconColours() { }

    public required (double R, double G, double B, double A) Colour;
    public required (byte R, byte G, byte B, byte A) RGB;
    public required int HexLinear;
    public required int HexSRGB;
}