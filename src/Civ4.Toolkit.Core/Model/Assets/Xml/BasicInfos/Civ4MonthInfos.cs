using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4MonthInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4MonthInfos : Civ4AssetFile
{
    [XmlArray("MonthInfos")]
    [XmlArrayItem("MonthInfo")]
    public Civ4MonthInfo[]? MonthInfos { get; set; }
}
