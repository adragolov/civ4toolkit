using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4CivilizationUnit
{
    [XmlElement("UnitClassType", Order = 1)]
    public string? UnitClassType { get; set; }
    
    [XmlElement("UnitType", Order = 2)]
    public string? UnitType { get; set; }

    public override string ToString()
    {
        return $"Unit Class = {UnitClassType}, Unit Type = {UnitType}";
    }
}