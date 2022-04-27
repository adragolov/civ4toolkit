using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4InterfaceArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Path", Order = 2)]
    public string? Path { get; set; }

    public override string ToString()
    {
        return $"InterfaceArtInfo = {Type}";
    }
}
