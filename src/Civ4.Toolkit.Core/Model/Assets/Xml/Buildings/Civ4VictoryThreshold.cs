using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

public class Civ4VictoryThreshold
{
    [XmlElement("VictoryType", Order = 1)]
    public string? VictoryType { get; set; }
    
    [XmlElement("iThreshold", Order = 2)]
    public int? Threshold { get; set; }
    
    public override string ToString()
    {
        return $"Victory Type = {VictoryType}, iThreshold = {Threshold}";
    }
}