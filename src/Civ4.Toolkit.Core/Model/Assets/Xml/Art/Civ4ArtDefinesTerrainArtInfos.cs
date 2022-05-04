using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesTerrainArtInfos : Civ4AssetFile
{
    [XmlArray("TerrainArtInfos")]
    [XmlArrayItem("TerrainArtInfo")]
    public Civ4TerrainArtInfo[]? TerrainArtInfos { get; set; }
}
