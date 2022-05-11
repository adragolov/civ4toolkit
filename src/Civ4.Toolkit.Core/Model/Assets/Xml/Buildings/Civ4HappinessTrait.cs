using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

public class Civ4HappinessTrait
{
    [XmlElement("HappinessTraitType", Order = 1)]
    public string? HappinessTraitType { get; set; }
    
    [XmlElement("iHappinessTrait", Order = 2)]
    public int? HappinessTrait { get; set; }
    
    public override string ToString()
    {
        return $"Happiness Trait Type = {HappinessTraitType}, iHappinessTrait = {HappinessTrait}";
    }
}