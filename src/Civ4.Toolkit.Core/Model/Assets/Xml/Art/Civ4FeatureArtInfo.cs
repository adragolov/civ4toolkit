using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4FeatureArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("bAnimated", Order = 2)]
    public byte? Animated { get; set; }
    
    [XmlElement("bRiverArt", Order = 3)]
    public byte? RiverArt { get; set; }
    
    [XmlElement("TileArtType", Order = 4)]
    public string? TileArtType { get; set; }
    
    [XmlElement("LightType", Order = 5)]
    public string? LightType { get; set; }
    
    [XmlElement("fScale", Order = 6)]
    public float? Scale { get; set; }
    
    [XmlElement("fInterfaceScale", Order = 7)]
    public float? InterfaceScale { get; set; }

    [XmlElement("Button", Order = 8)]
    public string? Button { get; set; }
    
    [XmlElement("FeatureVariety", Order = 9)]
    public Civ4FeatureArtPieces[]? FeatureVarieties { get; set; }
    
    public override string ToString()
    {
        return $"FeatureArtInfo = {Type}";
    }
}
