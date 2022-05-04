using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesMiscArtInfos : Civ4AssetFile
{
    [XmlArray("MiscArtInfos")]
    [XmlArrayItem("MiscArtInfo")]
    public Civ4MiscArtInfo[]? MiscArtInfos { get; set; }
}
