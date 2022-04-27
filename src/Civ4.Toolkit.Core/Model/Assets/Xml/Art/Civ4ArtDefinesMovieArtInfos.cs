
using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesMovieArtInfos : Civ4AssetFile
{
    [XmlArray("MovieArtInfos")]
    [XmlArrayItem("MovieArtInfo")]
    public Civ4MovieArtInfo[]? MovieArtInfos { get; set; }
}
