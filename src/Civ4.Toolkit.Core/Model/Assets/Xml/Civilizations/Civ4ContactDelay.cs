using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4ContactDelay
{
    [XmlElement("ContactType", Order = 1)]
    public string? ContactType { get; set; }
    
    [XmlElement("iContactDelay", Order = 2)]
    public int? Value { get; set; }

    public override string ToString()
    {
        return $"ContactDelay = {ContactType}, iContactDelay = {Value}";
    }
}