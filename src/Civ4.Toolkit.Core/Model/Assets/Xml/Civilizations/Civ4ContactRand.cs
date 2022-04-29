using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4ContactRand
{
    [XmlElement("ContactType", Order = 1)]
    public string? ContactType { get; set; }
    
    [XmlElement("iContactRand", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"ContactRand = {ContactType}, iContactRand = {Value}";
    }
}