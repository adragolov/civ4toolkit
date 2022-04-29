using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4ImprovementWeightModifier
{
    [XmlElement("ImprovementType", Order = 1)]
    public string? ImprovementType { get; set; }
    
    [XmlElement("iWeightModifier", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"ImprovementWeightModifier = {ImprovementType}, iWeightModifier = {Value}";
    }
}