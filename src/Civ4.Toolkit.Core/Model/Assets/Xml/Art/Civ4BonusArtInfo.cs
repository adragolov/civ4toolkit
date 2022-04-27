using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4BonusArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("fScale", Order = 2)]
    public float? Scale { get; set; }
    
    [XmlElement("fInterfaceScale", Order = 3)]
    public float? InterfaceScale { get; set; }

    [XmlElement("NIF", Order = 4)]
    public string? NIF { get; set; }
    
    [XmlElement("KFM", Order = 5)]
    public string? KFM { get; set; }

    [XmlElement("SHADERNIF", Order = 6)]
    public string? SHADERNIF { get; set; }
    
    [XmlElement("Button", Order = 7)]
    public string? Button { get; set; }
    
    [XmlElement("FontButtonIndex", Order = 8)]
    public int? FontButtonIndex { get; set; }

    public override string ToString()
    {
        return $"BonusArtInfo = {Type}";
    }
}
