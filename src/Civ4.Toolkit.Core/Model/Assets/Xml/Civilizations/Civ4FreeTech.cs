using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4FreeTech
{
    [XmlElement("TechType", Order = 1)]
    public string? TechType { get; set; }
    
    [XmlElement("bFreeTech", Order = 2)]
    public byte? FreeTech { get; set; }

    public override string ToString()
    {
        return $"Technology Type = {TechType}, bFreeTech = {FreeTech}";
    }
}