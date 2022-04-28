using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4UnitAIInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4UnitAIInfos : Civ4AssetFile
{
    [XmlArray("UnitAIInfos")]
    [XmlArrayItem("UnitAIInfo")]
    public Civ4UnitAIInfo[]? UnitAIInfos { get; set; }
}
