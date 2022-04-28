using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4CityTabInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4CityTabInfos : Civ4AssetFile
{
    [XmlArray("CityTabInfos")]
    [XmlArrayItem("CityTabInfo")]
    public Civ4CityTabInfo[]? CityTabInfos { get; set; }
}
