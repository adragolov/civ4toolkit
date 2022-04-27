using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesBuildingArtInfos : Civ4AssetFile
{
    [XmlArray("BuildingArtInfos")]
    [XmlArrayItem("BuildingArtInfo")]
    public Civ4BuildingArtInfo[]? BuildingArtInfos { get; set; }
}
