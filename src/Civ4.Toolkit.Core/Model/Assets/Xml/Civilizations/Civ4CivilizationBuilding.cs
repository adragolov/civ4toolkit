using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4CivilizationBuilding
{
    [XmlElement("BuildingClassType", Order = 1)]
    public string? BuildingClassType { get; set; }
    
    [XmlElement("BuildingType", Order = 2)]
    public string? BuildingType { get; set; }

    public override string ToString()
    {
        return $"Building Class = {BuildingClassType}, Building Type = {BuildingType}";
    }
}
