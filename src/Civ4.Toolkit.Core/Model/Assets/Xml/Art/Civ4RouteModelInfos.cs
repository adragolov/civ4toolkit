using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4RouteModelInfos", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4RouteModelInfos : Civ4AssetFile
{
    [XmlArray("RouteModelInfos")]
    [XmlArrayItem("RouteModelInfo")]
    public Civ4RouteModelInfo[]? RouteModelInfos { get; set; }
}
