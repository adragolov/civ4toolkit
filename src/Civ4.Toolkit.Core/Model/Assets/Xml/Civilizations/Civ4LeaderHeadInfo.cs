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
    
    [XmlElement("iSameReligionAttitudeChange", Order = 39)]
    public int? SameReligionAttitudeChange { get; set; }
    
    [XmlElement("iSameReligionAttitudeDivisor", Order = 40)]
    public int? SameReligionAttitudeDivisor { get; set; }
    
    [XmlElement("iSameReligionAttitudeChangeLimit", Order = 41)]
    public int? SameReligionAttitudeChangeLimit { get; set; }
    
    [XmlElement("iDifferentReligionAttitudeChange", Order = 42)]
    public int? DifferentReligionAttitudeChange { get; set; }
    
    [XmlElement("iDifferentReligionAttitudeDivisor", Order = 43)]
    public int? DifferentReligionAttitudeDivisor { get; set; }
    
    [XmlElement("iDifferentReligionAttitudeChangeLimit", Order = 44)]
    public int? DifferentReligionAttitudeChangeLimit { get; set; }
    
    [XmlElement("iBonusTradeAttitudeDivisor", Order = 45)]
    public int? BonusTradeAttitudeDivisor { get; set; }
    
    [XmlElement("iBonusTradeAttitudeChangeLimit", Order = 46)]
    public int? BonusTradeAttitudeChangeLimit { get; set; }
    
    [XmlElement("iOpenBordersAttitudeDivisor", Order = 47)]
    public int? OpenBordersAttitudeDivisor { get; set; }
    
    [XmlElement("iOpenBordersAttitudeChangeLimit", Order = 48)]
    public int? OpenBordersAttitudeChangeLimit { get; set; }
    
    [XmlElement("iDefensivePactAttitudeDivisor", Order = 49)]
    public int? DefensivePactAttitudeDivisor { get; set; }
    
    [XmlElement("iDefensivePactAttitudeChangeLimit", Order = 50)]
    public int? DefensivePactAttitudeChangeLimit { get; set; }
    
    [XmlElement("iShareWarAttitudeChange", Order = 51)]
    public int? ShareWarAttitudeChange { get; set; }
    
    [XmlElement("iShareWarAttitudeDivisor", Order = 52)]
    public int? ShareWarAttitudeDivisor { get; set; }
    
    [XmlElement("iShareWarAttitudeChangeLimit", Order = 53)]
    public int? ShareWarAttitudeChangeLimit { get; set; }
    
    [XmlElement("iFavoriteCivicAttitudeChange", Order = 54)]
    public int? FavoriteCivicAttitudeChange { get; set; }
    
    [XmlElement("iFavoriteCivicAttitudeDivisor", Order = 55)]
    public int? FavoriteCivicAttitudeDivisor { get; set; }
    
    [XmlElement("iFavoriteCivicAttitudeChangeLimit", Order = 56)]
    public int? FavoriteCivicAttitudeChangeLimit { get; set; }
    
    [XmlElement("DemandTributeAttitudeThreshold", Order = 57)]
    public string? DemandTributeAttitudeThreshold { get; set; }
    
    [XmlElement("NoGiveHelpAttitudeThreshold", Order = 58)]
    public string? NoGiveHelpAttitudeThreshold { get; set; }
    
    [XmlElement("TechRefuseAttitudeThreshold", Order = 59)]
    public string? TechRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("StrategicBonusRefuseAttitudeThreshold", Order = 60)]
    public string? StrategicBonusRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("HappinessBonusRefuseAttitudeThreshold", Order = 61)]
    public string? HappinessBonusRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("HealthBonusRefuseAttitudeThreshold", Order = 62)]
    public string? HealthBonusRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("MapRefuseAttitudeThreshold", Order = 63)]
    public string? MapRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("DeclareWarRefuseAttitudeThreshold", Order = 64)]
    public string? DeclareWarRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("DeclareWarThemRefuseAttitudeThreshold", Order = 65)]
    public string? DeclareWarThemRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("StopTradingRefuseAttitudeThreshold", Order = 66)]
    public string? StopTradingRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("StopTradingThemRefuseAttitudeThreshold", Order = 67)]
    public string? StopTradingThemRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("AdoptCivicRefuseAttitudeThreshold", Order = 68)]
    public string? AdoptCivicRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("ConvertReligionRefuseAttitudeThreshold", Order = 69)]
    public string? ConvertReligionRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("OpenBordersRefuseAttitudeThreshold", Order = 70)]
    public string? OpenBordersRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("DefensivePactRefuseAttitudeThreshold", Order = 71)]
    public string? DefensivePactRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("PermanentAllianceRefuseAttitudeThreshold", Order = 72)]
    public string? PermanentAllianceRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("VassalRefuseAttitudeThreshold", Order = 73)]
    public string? VassalRefuseAttitudeThreshold { get; set; }
    
    [XmlElement("iVassalPowerModifier", Order = 74)]
    public int? VassalPowerModifier { get; set; }
    
    [XmlElement("iFreedomAppreciation", Order = 75)]
    public int? FreedomAppreciation { get; set; }
    
    [XmlElement("FavoriteCivic", Order = 76)]
    public string? FavoriteCivic { get; set; }
    
    [XmlElement("FavoriteReligion", Order = 77)]
    public string? FavoriteReligion { get; set; }
    
    [XmlArray("Traits", Order = 78)]
    [XmlArrayItem("Trait")]
    public Civ4Trait[]? Traits { get; set; }
    
    [XmlArray("Flavors", Order = 79)]
    [XmlArrayItem("Flavor")]
    public Civ4Flavor[]? Flavors { get; set; }
    
    [XmlArray("ContactRands", Order = 80)]
    [XmlArrayItem("ContactRand")]
    public Civ4ContactRand[]? ContactRands { get; set; }
    
    [XmlArray("ContactDelays", Order = 81)]
    [XmlArrayItem("ContactDelay")]
    public Civ4ContactDelay[]? ContactDelays { get; set; }
    
    [XmlArray("MemoryDecays", Order = 82)]
    [XmlArrayItem("MemoryDecay")]
    public Civ4MemoryDecay[]? MemoryDecays { get; set; }
    
    [XmlArray("MemoryAttitudePercents", Order = 83)]
    [XmlArrayItem("MemoryAttitudePercent")]
    public Civ4MemoryAttitudePercent[]? MemoryAttitudePercents { get; set; }
    
    [XmlArray("NoWarAttitudeProbs", Order = 84)]
    [XmlArrayItem("NoWarAttitudeProb")]
    public Civ4NoWarAttitudeProb[]? NoWarAttitudeProbs { get; set; }
    
    [XmlArray("UnitAIWeightModifiers", Order = 85)]
    [XmlArrayItem("UnitAIWeightModifier")]
    public Civ4UnitAIWeightModifier[]? UnitAIWeightModifiers { get; set; }
    
    [XmlArray("ImprovementWeightModifiers", Order = 86)]
    [XmlArrayItem("ImprovementWeightModifier")]
    public Civ4ImprovementWeightModifier[]? ImprovementWeightModifiers { get; set; }
    
    [XmlArray("DiplomacyIntroMusicPeace", Order = 87)]
    [XmlArrayItem("DiploMusicPeaceEra")]
    public Civ4DiplomacyMusicEra[]? DiplomacyIntroMusicPeace { get; set; }
    
    [XmlArray("DiplomacyMusicPeace", Order = 88)]
    [XmlArrayItem("DiploMusicPeaceEra")]
    public Civ4DiplomacyMusicEra[]? DiplomacyMusicPeace { get; set; }
    
    [XmlArray("DiplomacyIntroMusicWar", Order = 89)]
    [XmlArrayItem("DiploMusicWarEra")]
    public Civ4DiplomacyMusicEra[]? DiplomacyIntroMusicWar { get; set; }
    
    [XmlArray("DiplomacyMusicWar", Order = 90)]
    [XmlArrayItem("DiploMusicWarEra")]
    public Civ4DiplomacyMusicEra[]? DiplomacyMusicWar { get; set; }

    public override string ToString()
    {
        return $"LeaderHeadInfo = {Type}";
    }
}
