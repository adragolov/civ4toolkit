using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4TraitInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    [XmlElement("ShortDescription", Order = 3)]
    public string? ShortDescription { get; set; }
    
    [XmlElement("iHealth", Order = 4)]
    public int? Health { get; set; }
    
    [XmlElement("iHappiness", Order = 5)]
    public int? Happiness { get; set; }
    
    [XmlElement("iMaxAnarchy", Order = 6)]
    public int? MaxAnarchy { get; set; }
    
    [XmlElement("iUpkeepModifier", Order = 7)]
    public int? UpkeepModifier { get; set; }
    
    [XmlElement("iLevelExperienceModifier", Order = 8)]
    public int? LevelExperienceModifier { get; set; }
    
    [XmlElement("iGreatPeopleRateModifier", Order = 9)]
    public int? GreatPeopleRateModifier { get; set; }
    
    [XmlElement("iGreatGeneralRateModifier", Order = 10)]
    public int? GreatGeneralRateModifier { get; set; }
    
    [XmlElement("iDomesticGreatGeneralRateModifier", Order = 11)]
    public int? DomesticGreatGeneralRateModifier { get; set; }
    
    [XmlElement("iMaxGlobalBuildingProductionModifier", Order = 12)]
    public int? MaxGlobalBuildingProductionModifier { get; set; }
    
    [XmlElement("iMaxTeamBuildingProductionModifier", Order = 13)]
    public int? MaxTeamBuildingProductionModifier { get; set; }
    
    [XmlElement("iMaxPlayerBuildingProductionModifier", Order = 14)]
    public int? MaxPlayerBuildingProductionModifier { get; set; }
    
    [XmlArray("ExtraYieldThresholds", Order = 15)]
    [XmlArrayItem("iExtraYieldThreshold")]
    public int[]? ExtraYieldThresholds { get; set; }
    
    [XmlArray("TradeYieldModifiers", Order = 16)]
    [XmlArrayItem("iYield")]
    public int[]? TradeYieldModifiers { get; set; }
    
    [XmlArray("CommerceChanges", Order = 17)]
    [XmlArrayItem("iCommerce")]
    public int[]? CommerceChanges { get; set; }
    
    [XmlArray("CommerceModifiers", Order = 18)]
    [XmlArrayItem("iCommerce")]
    public int[]? CommerceModifiers { get; set; }
    
    [XmlArray("FreePromotions", Order = 19)]
    [XmlArrayItem("FreePromotion")]
    public Civ4FreePromotion[]? FreePromotions { get; set; }
    
    [XmlArray("FreePromotionUnitCombats", Order = 20)]
    [XmlArrayItem("FreePromotionUnitCombat")]
    public Civ4FreePromotionUnitCombat[]? FreePromotionUnitCombats { get; set; }

    public override string ToString()
    {
        return $"TraitInfo = {Type}";
    }
}