using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

public class Civ4ProductionTrait
{
    [XmlElement("ProductionTraitType", Order = 1)]
    public string? ProductionTraitType { get; set; }
    
    [XmlElement("iProductionTrait", Order = 2)]
    public int? ProductionTrait { get; set; }
    
    public override string ToString()
    {
        return $"Production Trait Type = {ProductionTraitType}, iProductionTrait = {ProductionTrait}";
    }
}