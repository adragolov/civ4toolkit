using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4FreeUnitClass
{
    [XmlElement("UnitClassType", Order = 1)]
    public string? UnitClassType { get; set; }
    
    [XmlElement("iFreeUnits", Order = 2)]
    public int? FreeUnits { get; set; }

    public override string ToString()
    {
        return $"Unit Class = {UnitClassType}, iFreeUnits = {FreeUnits}";
    }
}