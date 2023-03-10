using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

[XmlRoot("Civ4BuildingClassInfos", Namespace = "x-schema:CIV4BuildingsSchema.xml")]
public class Civ4BuildingClassInfos : Civ4AssetFile
{
    [XmlArray("BuildingClassInfos")]
    [XmlArrayItem("BuildingClassInfo")]
    public Civ4BuildingClassInfo[]? BuildingClassInfos { get; set; }
}
