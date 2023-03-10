using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

public class Civ4BuildingClassInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    [XmlElement("iMaxGlobalInstances", Order = 3)]
    public int? MaxGlobalInstances { get; set; }
    
    [XmlElement("iMaxTeamInstances", Order = 4)]
    public int? MaxTeamInstances { get; set; }
    
    [XmlElement("iMaxPlayerInstances", Order = 5)]
    public int? MaxPlayerInstances { get; set; }
    
    [XmlElement("iExtraPlayerInstances", Order = 6)]
    public int? ExtraPlayerInstances { get; set; }
    
    [XmlElement("bNoLimit", Order = 7)]
    public byte? NoLimit { get; set; }
    
    [XmlElement("DefaultBuilding", Order = 8)]
    public string? DefaultBuilding { get; set; }
    
    [XmlArray("VictoryThresholds", Order = 9)]
    [XmlArrayItem("VictoryThreshold")]
    public Civ4VictoryThreshold[]? VictoryThresholds { get; set; }
    
    public override string ToString()
    {
        return $"Building Class = {Type}";
    }
}