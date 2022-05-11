using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

public class Civ4BuildingInfo
{
    [XmlElement("BuildingClass", Order = 1)]
    public string? BuildingClass { get; set; }
    
    [XmlElement("Type", Order = 2)]
    public string? Type { get; set; }
    
    [XmlElement("SpecialBuildingType", Order = 3)]
    public string? SpecialBuildingType { get; set; }
    
    [XmlElement("Description", Order = 4)]
    public string? Description { get; set; }
    
    [XmlElement("Civilopedia", Order = 5)]
    public string? Civilopedia { get; set; }
    
    [XmlElement("Strategy", Order = 6)]
    public string? Strategy { get; set; }
    
    [XmlElement("Advisor", Order = 7)]
    public string? Advisor { get; set; }
    
    [XmlElement("ArtDefineTag", Order = 8)]
    public string? ArtDefineTag { get; set; }
    
    [XmlElement("MovieDefineTag", Order = 9)]
    public string? MovieDefineTag { get; set; }
    
    [XmlElement("HolyCity", Order = 10)]
    public string? HolyCity { get; set; }
    
    [XmlElement("ReligionType", Order = 11)]
    public string? ReligionType { get; set; }
    
    [XmlElement("StateReligion", Order = 12)]
    public string? StateReligion { get; set; }
    
    [XmlElement("bStateReligion", Order = 13)]
    public byte? RequiresStateReligion { get; set; }
    
    [XmlElement("PrereqReligion", Order = 14)]
    public string? PrereqReligion { get; set; }
    
    [XmlElement("PrereqCorporation", Order = 15)]
    public string? PrerequisiteCorporation { get; set; }
    
    [XmlElement("FoundsCorporation", Order = 16)]
    public string? FoundsCorporation { get; set; }
    
    [XmlElement("GlobalReligionCommerce", Order = 17)]
    public string? GlobalReligionCommerce { get; set; }
    
    [XmlElement("GlobalCorporationCommerce", Order = 18)]
    public string? GlobalCorporationCommerce { get; set; }
    
    [XmlElement("VictoryPrereq", Order = 19)]
    public string? VictoryPrerequisite { get; set; }
    
    [XmlElement("FreeStartEra", Order = 20)]
    public string? FreeStartEra { get; set; }
    
    [XmlElement("MaxStartEra", Order = 21)]
    public string? MaxStartEra { get; set; }
    
    [XmlElement("ObsoleteTech", Order = 22)]
    public string? ObsoleteTech { get; set; }
    
    [XmlElement("PrereqTech", Order = 23)]
    public string? PrerequisiteTech { get; set; }
    
    [XmlArray("TechTypes", Order = 24)]
    [XmlArrayItem("PrereqTech")]
    public string[]? TechTypes { get; set; }
    
    [XmlElement("Bonus", Order = 25)]
    public string? Bonus { get; set; }
    
    [XmlArray("PrereqBonuses", Order = 26)]
    [XmlArrayItem("Bonus")]
    public string[]? PrerequisiteBonuses { get; set; }
    
    [XmlArray("ProductionTraits", Order = 27)]
    [XmlArrayItem("ProductionTrait")]
    public Civ4ProductionTrait[]? ProductionTraits { get; set; }
    
    [XmlArray("HappinessTraits", Order = 28)]
    [XmlArrayItem("HappinessTrait")]
    public Civ4HappinessTrait[]? HappinessTraits { get; set; }
    
    [XmlElement("NoBonus", Order = 29)]
    public string? NoBonus { get; set; }
    
    [XmlElement("PowerBonus", Order = 30)]
    public string? PowerBonus { get; set; }
    
    [XmlElement("FreeBonus", Order = 31)]
    public string? FreeBonus { get; set; }
    
    [XmlElement("iNumFreeBonuses", Order = 32)]
    public int? NumFreeBonuses { get; set; }
    
    [XmlElement("FreeBuilding", Order = 33)]
    public string? FreeBuilding { get; set; }
    
    [XmlElement("FreePromotion", Order = 34)]
    public string? FreePromotion { get; set; }
    
    [XmlElement("CivicOption", Order = 35)]
    public string? CivicOption { get; set; }
    
    [XmlElement("GreatPeopleUnitClass", Order = 36)]
    public string? GreatPeopleUnitClass { get; set; }
    
    [XmlElement("iGreatPeopleRateChange", Order = 37)]
    public int? GreatPeopleRateChange { get; set; }
    
    [XmlElement("iHurryAngerModifier", Order = 38)]
    public int? HurryAngerModifier { get; set; }
    
    [XmlElement("bBorderObstacle", Order = 39)]
    public byte? BorderObstacle { get; set; }

    [XmlElement("bTeamShare", Order = 40)]
    public byte? TeamShare { get; set; }
    
    [XmlElement("bWater", Order = 41)]
    public byte? Water { get; set; }
    
    [XmlElement("bRiver", Order = 42)]
    public byte? River { get; set; }
    
    [XmlElement("bPower", Order = 43)]
    public byte? ProvidesPower { get; set; }
    
    [XmlElement("bDirtyPower", Order = 44)]
    public byte? ProvidesDirtyPower { get; set; }
    
    [XmlElement("bAreaCleanPower", Order = 45)]
    public byte? ProvidesAreaCleanPower { get; set; }
    
    [XmlElement("bDiploVote", Order = 46)]
    public byte? DiploVote { get; set; }
    
    [XmlElement("bForceTeamVoteEligible", Order = 47)]
    public byte? ForceTeamVoteEligible { get; set; }
    
    [XmlElement("bCapital", Order = 48)]
    public byte? Capital { get; set; }
    
    [XmlElement("bGovernmentCenter", Order = 49)]
    public byte? GovernmentCenter { get; set; }
    
    [XmlElement("bGoldenAge", Order = 50)]
    public byte? GoldenAge { get; set; }
    
    [XmlElement("bMapCentering", Order = 51)]
    public byte? MapCentering { get; set; }
    
    [XmlElement("bNoUnhappiness", Order = 52)]
    public byte? NoUnhappiness { get; set; }
    
    [XmlElement("bNoUnhealthyPopulation", Order = 53)]
    public byte? NoUnhealthyPopulation { get; set; }
    
    [XmlElement("bBuildingOnlyHealthy", Order = 54)]
    public byte? BuildingOnlyHealthy { get; set; }
    
    [XmlElement("bNeverCapture", Order = 55)]
    public byte? NeverCapture { get; set; }
    
    [XmlElement("bNukeImmune", Order = 56)]
    public byte? NukeImmune { get; set; }
    
    [XmlElement("bPrereqReligion", Order = 57)]
    public byte? PrerequisiteReligion { get; set; }
    
    [XmlElement("bCenterInCity", Order = 58)]
    public byte? CenterInCity { get; set; }
    
    [XmlElement("iAIWeight", Order = 59)]
    public int? AIWeight { get; set; }
    
    [XmlElement("iCost", Order = 60)]
    public int? Cost { get; set; }
    
    [XmlElement("iHurryCostModifier", Order = 61)]
    public int? HurryCostModifier { get; set; }
    
    [XmlElement("iMinAreaSize", Order = 62)]
    public int? MinAreaSize { get; set; }
    
    [XmlElement("iConquestProb", Order = 63)]
    public int? ConquestProbability { get; set; }
    
    [XmlElement("iCitiesPrereq", Order = 64)]
    public int? CitiesPrerequisite { get; set; }
    
    [XmlElement("iTeamsPrereq", Order = 65)]
    public int? TeamsPrerequisite { get; set; }
    
    [XmlElement("iLevelPrereq", Order = 66)]
    public int? LevelPrerequisite { get; set; }
    
    [XmlElement("iMinLatitude", Order = 67)]
    public int? MinLatitude { get; set; }
    
    [XmlElement("iMaxLatitude", Order = 68)]
    public int? MaxLatitude { get; set; }
    
    [XmlElement("iGreatPeopleRateModifier", Order = 69)]
    public int? GreatPeopleRateModifier { get; set; }
    
    [XmlElement("iGreatGeneralRateModifier", Order = 70)]
    public int? GreatGeneralRateModifier { get; set; }
    
    [XmlElement("iDomesticGreatGeneralRateModifier", Order = 71)]
    public int? DomesticGreatGeneralRateModifier { get; set; }
    
    [XmlElement("iGlobalGreatPeopleRateModifier", Order = 72)]
    public int? GlobalGreatPeopleRateModifier { get; set; }
    
    [XmlElement("iAnarchyModifier", Order = 73)]
    public int? AnarchyModifier { get; set; }
    
    [XmlElement("iGoldenAgeModifier", Order = 74)]
    public int? GoldenAgeModifier { get; set; }
    
    [XmlElement("iGlobalHurryModifier", Order = 75)]
    public int? GlobalHurryModifier { get; set; }
    
    [XmlElement("iExperience", Order = 76)]
    public int? Experience { get; set; }
    
    [XmlElement("iGlobalExperience", Order = 77)]
    public int? GlobalExperience { get; set; }
    
    [XmlElement("iFoodKept", Order = 78)]
    public int? FoodKept { get; set; }
    
    [XmlElement("iAirlift", Order = 79)]
    public int? Airlift { get; set; }
    
    [XmlElement("iAirModifier", Order = 80)]
    public int? AirModifier { get; set; }
    
    [XmlElement("iAirUnitCapacity", Order = 81)]
    public int? AirUnitCapacity { get; set; }
    
    [XmlElement("iNukeModifier", Order = 82)]
    public int? NukeModifier { get; set; }
    
    [XmlElement("iNukeExplosionRand", Order = 83)]
    public int? NukeExplosionRand { get; set; }
    
    [XmlElement("iFreeSpecialist", Order = 84)]
    public int? FreeSpecialist { get; set; }
    
    [XmlElement("iAreaFreeSpecialist", Order = 85)]
    public int? AreaFreeSpecialist { get; set; }
    
    [XmlElement("iGlobalFreeSpecialist", Order = 86)]
    public int? GlobalFreeSpecialist { get; set; }
    
    [XmlElement("iMaintenanceModifier", Order = 87)]
    public int? MaintenanceModifier { get; set; }
    
    [XmlElement("iWarWearinessModifier", Order = 88)]
    public int? WarWearinessModifier { get; set; }
    
    [XmlElement("iGlobalWarWearinessModifier", Order = 89)]
    public int? GlobalWarWearinessModifier { get; set; }
    
    [XmlElement("iEnemyWarWearinessModifier", Order = 90)]
    public int? EnemyWarWearinessModifier { get; set; }
    
    [XmlElement("iHealRateChange", Order = 91)]
    public int? HealRateChange { get; set; }
    
    [XmlElement("iHealth", Order = 92)]
    public int? Health { get; set; }
    
    [XmlElement("iAreaHealth", Order = 93)]
    public int? AreaHealth { get; set; }
    
    [XmlElement("iGlobalHealth", Order = 94)]
    public int? GlobalHealth { get; set; }
    
    [XmlElement("iHappiness", Order = 95)]
    public int? Happiness { get; set; }
    
    [XmlElement("iAreaHappiness", Order = 96)]
    public int? AreaHappiness { get; set; }
    
    [XmlElement("iGlobalHappiness", Order = 97)]
    public int? GlobalHappiness { get; set; }
    
    [XmlElement("iStateReligionHappiness", Order = 98)]
    public int? StateReligionHappiness { get; set; }
    
    [XmlElement("iWorkerSpeedModifier", Order = 99)]
    public int? WorkerSpeedModifier { get; set; }
    
    [XmlElement("iMilitaryProductionModifier", Order = 100)]
    public int? MilitaryProductionModifier { get; set; }
    
    [XmlElement("iSpaceProductionModifier", Order = 101)]
    public int? SpaceProductionModifier { get; set; }
    
    [XmlElement("iGlobalSpaceProductionModifier", Order = 102)]
    public int? GlobalSpaceProductionModifier { get; set; }
    
    [XmlElement("iTradeRoutes", Order = 103)]
    public int? TradeRoutes { get; set; }
    
    [XmlElement("iCoastalTradeRoutes", Order = 104)]
    public int? CoastalTradeRoutes { get; set; }
    
    [XmlElement("iGlobalTradeRoutes", Order = 105)]
    public int? GlobalTradeRoutes { get; set; }
    
    [XmlElement("iTradeRouteModifier", Order = 106)]
    public int? TradeRouteModifier { get; set; }
    
    [XmlElement("iForeignTradeRouteModifier", Order = 107)]
    public int? ForeignTradeRouteModifier { get; set; }
    
    [XmlElement("iGlobalPopulationChange", Order = 108)]
    public int? GlobalPopulationChange { get; set; }
    
    [XmlElement("iFreeTechs", Order = 109)]
    public int? FreeTechs { get; set; }
    
    [XmlElement("iDefense", Order = 110)]
    public int? Defense { get; set; }
    
    [XmlElement("iBombardDefense", Order = 111)]
    public int? BombardDefense { get; set; }
    
    [XmlElement("iAllCityDefense", Order = 112)]
    public int? AllCityDefense { get; set; }
    
    [XmlElement("iEspionageDefense", Order = 113)]
    public int? EspionageDefense { get; set; }
    
    [XmlElement("iAsset", Order = 114)]
    public int? Asset { get; set; }
    
    [XmlElement("iPower", Order = 115)]
    public int? Power { get; set; }
    
    [XmlElement("fVisibilityPriority", Order = 116)]
    public float? VisibilityPriority { get; set; }

    public override string ToString()
    {
        return $"Building Type = {Type}, Class = {BuildingClass}";
    }
}