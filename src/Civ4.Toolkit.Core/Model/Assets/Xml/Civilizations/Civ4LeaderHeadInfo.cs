using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4LeaderHeadInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    [XmlElement("Civilopedia", Order = 3)]
    public string? Civilopedia { get; set; }
    
    [XmlElement("ArtDefineTag", Order = 4)]
    public string? ArtDefineTag { get; set; }
    
    [XmlElement("iWonderConstructRand", Order = 5)]
    public int? WonderConstructRand { get; set; }
    
    [XmlElement("iBaseAttitude", Order = 6)]
    public int? BaseAttitude { get; set; }
    
    [XmlElement("iBasePeaceWeight", Order = 7)]
    public int? BasePeaceWeight { get; set; }
    
    [XmlElement("iPeaceWeightRand", Order = 8)]
    public int? PeaceWeightRand { get; set; }
    
    [XmlElement("iWarmongerRespect", Order = 9)]
    public int? WarmongerRespect { get; set; }
    
    [XmlElement("iEspionageWeight", Order = 10)]
    public int? EspionageWeight { get; set; }
    
    [XmlElement("iRefuseToTalkWarThreshold", Order = 11)]
    public int? RefuseToTalkWarThreshold { get; set; }
    
    [XmlElement("iNoTechTradeThreshold", Order = 12)]
    public int? NoTechTradeThreshold { get; set; }
    
    [XmlElement("iTechTradeKnownPercent", Order = 13)]
    public int? TechTradeKnownPercent { get; set; }
    
    [XmlElement("iMaxGoldTradePercent", Order = 14)]
    public int? MaxGoldTradePercent { get; set; }
    
    [XmlElement("iMaxGoldPerTurnTradePercent", Order = 15)]
    public int? MaxGoldPerTurnTradePercent { get; set; }
    
    [XmlElement("iMaxWarRand", Order = 16)]
    public int? MaxWarRand { get; set; }
    
    [XmlElement("iMaxWarNearbyPowerRatio", Order = 17)]
    public int? MaxWarNearbyPowerRatio { get; set; }
    
    [XmlElement("iMaxWarDistantPowerRatio", Order = 18)]
    public int? MaxWarDistantPowerRatio { get; set; }
    
    [XmlElement("iMaxWarMinAdjacentLandPercent", Order = 19)]
    public int? MaxWarMinAdjacentLandPercent { get; set; }
    
    [XmlElement("iLimitedWarRand", Order = 20)]
    public int? LimitedWarRand { get; set; }
    
    [XmlElement("iLimitedWarPowerRatio", Order = 21)]
    public int? LimitedWarPowerRatio { get; set; }
    
    [XmlElement("iDogpileWarRand", Order = 22)]
    public int? DogpileWarRand { get; set; }
    
    [XmlElement("iMakePeaceRand", Order = 23)]
    public int? MakePeaceRand { get; set; }
    
    [XmlElement("iDeclareWarTradeRand", Order = 24)]
    public int? DeclareWarTradeRand { get; set; }
    
    [XmlElement("iDemandRebukedSneakProb", Order = 25)]
    public int? DemandRebukedSneakProb { get; set; }
    
    [XmlElement("iDemandRebukedWarProb", Order = 26)]
    public int? DemandRebukedWarProb { get; set; }
    
    [XmlElement("iRazeCityProb", Order = 27)]
    public int? RazeCityProb { get; set; }
    
    [XmlElement("iBuildUnitProb", Order = 28)]
    public int? BuildUnitProb { get; set; }
    
    [XmlElement("iBaseAttackOddsChange", Order = 29)]
    public int? BaseAttackOddsChange { get; set; }
    
    [XmlElement("iAttackOddsChangeRand", Order = 30)]
    public int? AttackOddsChangeRand { get; set; }
    
    [XmlElement("iWorseRankDifferenceAttitudeChange", Order = 31)]
    public int? WorseRankDifferenceAttitudeChange { get; set; }
    
    [XmlElement("iBetterRankDifferenceAttitudeChange", Order = 32)]
    public int? BetterRankDifferenceAttitudeChange { get; set; }
    
    [XmlElement("iCloseBordersAttitudeChange", Order = 33)]
    public int? CloseBordersAttitudeChange { get; set; }
    
    [XmlElement("iLostWarAttitudeChange", Order = 34)]
    public int? LostWarAttitudeChange { get; set; }
    
    [XmlElement("iAtWarAttitudeDivisor", Order = 35)]
    public int? AtWarAttitudeDivisor { get; set; }
    
    [XmlElement("iAtWarAttitudeChangeLimit", Order = 36)]
    public int? AtWarAttitudeChangeLimit { get; set; }
    
    [XmlElement("iAtPeaceAttitudeDivisor", Order = 37)]
    public int? AtPeaceAttitudeDivisor { get; set; }
    
    [XmlElement("iAtPeaceAttitudeChangeLimit", Order = 38)]
    public int? AtPeaceAttitudeChangeLimit { get; set; }

    public override string ToString()
    {
        return $"LeaderHeadInfo = {Type}";
    }
}
