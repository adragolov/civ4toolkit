using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4DisableTech
{
    [XmlElement("TechType", Order = 1)]
    public string? TechType { get; set; }
    
    [XmlElement("bDisableTech", Order = 2)]
    public byte? DisableTech { get; set; }

    public override string ToString()
    {
        return $"Technology Type = {TechType}, bDisableTech = {DisableTech}";
    }
}
