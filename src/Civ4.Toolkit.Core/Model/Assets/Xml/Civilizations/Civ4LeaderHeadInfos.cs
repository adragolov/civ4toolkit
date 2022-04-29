using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

[XmlRoot("Civ4LeaderHeadInfos", Namespace = "x-schema:CIV4CivilizationsSchema.xml")]
public class Civ4LeaderHeadInfos : Civ4AssetFile
{
    [XmlArray("LeaderHeadInfos")]
    [XmlArrayItem("LeaderHeadInfo")]
    public Civ4LeaderHeadInfo[]? LeaderHeadInfos { get; set; }
}
