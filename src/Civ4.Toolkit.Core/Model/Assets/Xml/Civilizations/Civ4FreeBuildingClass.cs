using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4FreeBuildingClass
{
    [XmlElement("BuildingClassType", Order = 1)]
    public string? BuildingClassType { get; set; }
    
    [XmlElement("bFreeBuildingClass", Order = 2)]
    public byte? FreeBuildingClass { get; set; }

    public override string ToString()
    {
        return $"Building Class = {BuildingClassType}, bFreeBuildingClass = {FreeBuildingClass}";
    }
}