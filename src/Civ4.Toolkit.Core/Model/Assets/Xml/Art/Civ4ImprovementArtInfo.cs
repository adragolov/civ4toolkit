using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4ImprovementArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }

    [XmlElement("bExtraAnimations", Order = 2)]
    public byte? ExtraAnimations { get; set; }

    [XmlElement("fScale", Order = 3)]
    public float? Scale { get; set; }

    [XmlElement("fInterfaceScale", Order = 4)]
    public float? InterfaceScale { get; set; }

    [XmlElement("NIF", Order = 5)]
    public string? NIF { get; set; }

    [XmlElement("KFM", Order = 6)]
    public string? KFM { get; set; }

    [XmlElement("Button", Order = 7)]
    public string? Button { get; set; }
    
    public override string ToString()
    {
        return $"ImprovementArtInfo = {Type}";
    }
}
