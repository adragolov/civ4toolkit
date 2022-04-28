using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4NewConceptInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4NewConceptInfos : Civ4AssetFile
{
    [XmlArray("NewConceptInfos")]
    [XmlArrayItem("NewConceptInfo")]
    public Civ4NewConceptInfo[]? NewConceptInfos { get; set; }
}
