using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4SeasonInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4SeasonInfos : Civ4AssetFile
{
    [XmlArray("SeasonInfos")]
    [XmlArrayItem("SeasonInfo")]
    public Civ4SeasonInfo[]? SeasonInfos { get; set; }
}
