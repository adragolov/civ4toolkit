using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4LeaderheadArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Button", Order = 2)]
    public string? Button { get; set; }
    
    [XmlElement("NIF", Order = 3)]
    public string? NIF { get; set; }
    
    [XmlElement("KFM", Order = 4)]
    public string? KFM { get; set; }
    
    [XmlElement("NoShaderNIF", Order = 5)]
    public string? NoShaderNIF { get; set; }
    
    [XmlElement("BackgroundKFM", Order = 6)]
    public string? BackgroundKFM { get; set; }

    public override string ToString()
    {
        return $"LeaderheadArtInfo = {Type}";
    }
}
