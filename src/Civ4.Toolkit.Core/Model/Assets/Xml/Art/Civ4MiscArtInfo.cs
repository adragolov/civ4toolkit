using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4MiscArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Path", Order = 2)]
    public string? Path { get; set; }
    
    [XmlElement("fScale", Order = 3)]
    public float? Scale { get; set; }
    
    [XmlElement("NIF", Order = 4)]
    public string? NIF { get; set; }
    
    [XmlElement("KFM", Order = 5)]
    public string? KFM { get; set; }

    public override string ToString()
    {
        return $"MiscArtInfo = {Type}";
    }
}
