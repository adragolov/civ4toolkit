using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4MemoryInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4MemoryInfos : Civ4AssetFile
{
    [XmlArray("MemoryInfos")]
    [XmlArrayItem("MemoryInfo")]
    public Civ4MemoryInfo[]? MemoryInfos { get; set; }
}
