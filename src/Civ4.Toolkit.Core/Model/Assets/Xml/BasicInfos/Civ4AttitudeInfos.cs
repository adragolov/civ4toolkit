using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4AttitudeInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4AttitudeInfos : Civ4AssetFile
{
    [XmlArray("AttitudeInfos")]
    [XmlArrayItem("AttitudeInfo")]
    public Civ4AttitudeInfo[]? AttitudeInfos { get; set; }
}
