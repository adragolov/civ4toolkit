using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesCivilizationArtInfos : Civ4AssetFile
{
    [XmlArray("CivilizationArtInfos")]
    [XmlArrayItem("CivilizationArtInfo")]
    public Civ4CivilizationArtInfo[]? CivilizationArtInfos { get; set; }
}
