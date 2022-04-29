using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4BasicInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4BasicInfos : Civ4AssetFile
{
    [XmlArray("ConceptInfos")]
    [XmlArrayItem("ConceptInfo")]
    public Civ4BasicInfo[]? ConceptInfos { get; set; }
}
