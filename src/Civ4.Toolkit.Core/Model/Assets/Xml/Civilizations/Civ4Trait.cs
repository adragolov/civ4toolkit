using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4Trait
{
    [XmlElement("TraitType", Order = 1)]
    public string? TraitType { get; set; }
    
    [XmlElement("bTrait", Order = 2)]
    public byte? Enabled { get; set; }

    public override string ToString()
    {
        return $"Trait = {TraitType}, Enabled = {Enabled}";
    }
}
