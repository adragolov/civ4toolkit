using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesUnitArtInfos : Civ4AssetFile
{
    [XmlArray("UnitArtInfos")]
    [XmlArrayItem("UnitArtInfo")]
    public Civ4UnitArtInfo[]? UnitArtInfos { get; set; }
}
