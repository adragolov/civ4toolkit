using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4DenialInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4DenialInfos : Civ4AssetFile
{
    [XmlArray("DenialInfos")]
    [XmlArrayItem("DenialInfo")]
    public Civ4DenialInfos[]? DenialInfos { get; set; }
}
