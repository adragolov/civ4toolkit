using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4Flavor
{
    [XmlElement("FlavorType", Order = 1)]
    public string? FlavorType { get; set; }
    
    [XmlElement("iFlavor", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"Flavor = {FlavorType}, iFlavor = {Value}";
    }
}