using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4BuildingArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("LSystem", Order = 2)]
    public string? LSystem { get; set; }
    
    [XmlElement("bAnimated", Order = 3)]
    public byte? Animated { get; set; }
    
    [XmlElement("fScale", Order = 4)]
    public float? Scale { get; set; }
    
    [XmlElement("fInterfaceScale", Order = 5)]
    public float? InterfaceScale { get; set; }
    
    [XmlElement("NIF", Order = 6)]
    public string? NIF { get; set; }
    
    [XmlElement("KFM", Order = 7)]
    public string? KFM { get; set; }
    
    [XmlElement("Button", Order = 8)]
    public string? Button { get; set; }

    public override string ToString()
    {
        return $"BuildingArtInfo = {Type}";
    }
}