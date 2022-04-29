using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4MemoryAttitudePercent
{
    [XmlElement("MemoryType", Order = 1)]
    public string? MemoryType { get; set; }
    
    [XmlElement("iMemoryAttitudePercent", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"MemoryAttitudePercent = {MemoryType}, iMemoryAttitudePercent = {Value}";
    }
}