using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4UnitCombatInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4UnitCombatInfos : Civ4AssetFile
{
    [XmlArray("UnitCombatInfos")]
    [XmlArrayItem("UnitCombatInfo")]
    public Civ4UnitCombatInfo[]? UnitCombatInfos { get; set; }
}
