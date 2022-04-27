using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesFeatureArtInfos : Civ4AssetFile
{
    [XmlArray("FeatureArtInfos")]
    [XmlArrayItem("FeatureArtInfo")]
    public Civ4FeatureArtInfo[]? FeatureArtInfos { get; set; }
}
