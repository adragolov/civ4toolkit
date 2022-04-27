using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesImprovementArtInfos : Civ4AssetFile
{
    [XmlArray("ImprovementArtInfos")]
    [XmlArrayItem("ImprovementArtInfo")]
    public Civ4ImprovementArtInfo[]? ImprovementArtInfos { get; set; }
}
