
using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4ArtDefines", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4ArtDefinesInterfaceArtInfos : Civ4AssetFile
{
    [XmlArray("InterfaceArtInfos")]
    [XmlArrayItem("InterfaceArtInfo")]
    public Civ4InterfaceArtInfo[]? InterfaceArtInfos { get; set; }
}
