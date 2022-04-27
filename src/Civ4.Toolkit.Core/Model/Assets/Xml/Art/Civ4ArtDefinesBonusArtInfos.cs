using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesBonusArtInfos : Civ4AssetFile
{
    [XmlArray("BonusArtInfos")]
    [XmlArrayItem("BonusArtInfo")]
    public Civ4BonusArtInfo[]? BonusArtInfos { get; set; }
}
