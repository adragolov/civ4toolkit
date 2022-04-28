using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4InvisibleInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4InvisibleInfos : Civ4AssetFile
{
    [XmlArray("InvisibleInfos")]
    [XmlArrayItem("InvisibleInfo")]
    public Civ4AttitudeInfo[]? InvisibleInfos { get; set; }
}
