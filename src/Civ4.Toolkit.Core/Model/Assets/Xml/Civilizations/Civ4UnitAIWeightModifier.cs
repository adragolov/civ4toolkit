using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4UnitAIWeightModifier
{
    [XmlElement("UnitAIType", Order = 1)]
    public string? UnitAIType { get; set; }
    
    [XmlElement("iWeightModifier", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"UnitAIWeightModifier = {UnitAIType}, iWeightModifier = {Value}";
    }
}