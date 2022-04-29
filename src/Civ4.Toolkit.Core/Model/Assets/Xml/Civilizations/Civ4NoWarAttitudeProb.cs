using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4NoWarAttitudeProb
{
    [XmlElement("AttitudeType", Order = 1)]
    public string? AttitudeType { get; set; }
    
    [XmlElement("iNoWarProb", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"NoWarAttitudeProb = {AttitudeType}, iNoWarProb = {Value}";
    }
}