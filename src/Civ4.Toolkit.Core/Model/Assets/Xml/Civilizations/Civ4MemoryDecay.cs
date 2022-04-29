using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4MemoryDecay
{
    [XmlElement("MemoryType", Order = 1)]
    public string? MemoryType { get; set; }
    
    [XmlElement("iMemoryRand", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"MemoryDecay = {MemoryType}, iMemoryRand = {Value}";
    }
}