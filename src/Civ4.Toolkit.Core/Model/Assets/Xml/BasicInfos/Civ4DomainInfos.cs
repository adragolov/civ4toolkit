using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4DomainInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4DomainInfos : Civ4AssetFile
{
    [XmlArray("DomainInfos")]
    [XmlArrayItem("DomainInfo")]
    public Civ4DomainInfo[]? DomainInfos { get; set; }
}
