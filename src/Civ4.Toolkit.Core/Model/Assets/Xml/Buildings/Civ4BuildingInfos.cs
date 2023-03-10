using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Buildings;

[XmlRoot("Civ4BuildingInfos", Namespace = "x-schema:CIV4BuildingsSchema.xml")]
public class Civ4BuildingInfos : Civ4AssetFile
{
    [XmlArray("BuildingInfos")]
    [XmlArrayItem("BuildingInfo")]
    public Civ4BuildingInfo[]? BuildingInfos { get; set; }    
}