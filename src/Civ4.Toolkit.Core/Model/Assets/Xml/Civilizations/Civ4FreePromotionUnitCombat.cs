using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4FreePromotionUnitCombat
{
    [XmlElement("UnitCombatType", Order = 1)]
    public string? UnitCombatType { get; set; }
    
    [XmlElement("bFreePromotionUnitCombat", Order = 2)]
    public byte? Enabled { get; set; }

    public override string ToString()
    {
        return $"FreePromotionUnitCombat = {UnitCombatType}, bFreePromotionUnitCombat = {Enabled}";
    }
}
