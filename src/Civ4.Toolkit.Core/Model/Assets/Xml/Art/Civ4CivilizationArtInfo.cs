using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4CivilizationArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Button", Order = 2)]
    public string? Button { get; set; }
    
    [XmlElement("Path", Order = 3)]
    public string? Path { get; set; }
    
    [XmlElement("bWhiteFlag", Order = 4)]
    public byte? WhiteFlag { get; set; }
    
    public override string ToString()
    {
        return $"CivilizationArtInfo = {Type}";
    }
}
