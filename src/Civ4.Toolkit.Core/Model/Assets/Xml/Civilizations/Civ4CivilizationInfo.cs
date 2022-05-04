using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4CivilizationInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    [XmlElement("ShortDescription", Order = 3)]
    public string? ShortDescription { get; set; }
    
    [XmlElement("Adjective", Order = 4)]
    public string? Adjective { get; set; }
    
    [XmlElement("Civilopedia", Order = 5)]
    public string? Civilopedia { get; set; }
    
    [XmlElement("DefaultPlayerColor", Order = 6)]
    public string? DefaultPlayerColor { get; set; }
    
    [XmlElement("ArtDefineTag", Order = 7)]
    public string? ArtDefineTag { get; set; }
    
    [XmlElement("ArtStyleType", Order = 8)]
    public string? ArtStyleType { get; set; }
    
    [XmlElement("UnitArtStyleType", Order = 9)]
    public string? UnitArtStyleType { get; set; }
    
    [XmlElement("bPlayable", Order = 10)]
    public byte? Playable { get; set; }
    
    [XmlElement("bAIPlayable", Order = 11)]
    public byte? AIPlayable { get; set; }
    
    [XmlArray("Cities", Order = 12)]
    [XmlArrayItem("City")]
    public string[]? Cities { get; set; }
    
    [XmlArray("Buildings", Order = 13)]
    [XmlArrayItem("Building")]
    public Civ4CivilizationBuilding[]? Buildings { get; set; }
    
    [XmlArray("Units", Order = 14)]
    [XmlArrayItem("Unit")]
    public Civ4CivilizationUnit[]? Units { get; set; }
    
    [XmlArray("FreeUnitClasses", Order = 15)]
    [XmlArrayItem("FreeUnitClass")]
    public Civ4FreeUnitClass[]? FreeUnitClasses { get; set; }
    
    [XmlArray("FreeBuildingClasses", Order = 16)]
    [XmlArrayItem("FreeBuildingClass")]
    public Civ4FreeBuildingClass[]? FreeBuildingClasses { get; set; }
    
    [XmlArray("FreeTechs", Order = 17)]
    [XmlArrayItem("FreeTech")]
    public Civ4FreeTech[]? FreeTechs { get; set; }
    
    [XmlArray("DisableTechs", Order = 18)]
    [XmlArrayItem("DisableTech")]
    public Civ4DisableTech[]? DisableTechs { get; set; }
    
    [XmlArray("InitialCivics", Order = 19)]
    [XmlArrayItem("CivicType")]
    public string[]? InitialCivics { get; set; }
    
    [XmlArray("Leaders", Order = 20)]
    [XmlArrayItem("Leader")]
    public Civ4LeaderAvailability[]? Leaders { get; set; }
    
    [XmlElement("DerivativeCiv", Order = 21)]
    public string? DerivativeCiv { get; set; }
    
    [XmlElement("CivilizationSelectionSound", Order = 22)]
    public string? CivilizationSelectionSound { get; set; }
    
    [XmlElement("CivilizationActionSound", Order = 23)]
    public string? CivilizationActionSound { get; set; }
    
    public override string ToString()
    {
        return $"CivilizationInfo = {Type}";
    }
}
