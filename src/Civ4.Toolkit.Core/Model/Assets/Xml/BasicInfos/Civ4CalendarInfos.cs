using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

[XmlRoot("Civ4CalendarInfos", Namespace = "x-schema:CIV4BasicInfoSchema.xml")]
public class Civ4CalendarInfos : Civ4AssetFile
{
    [XmlArray("CalendarInfos")]
    [XmlArrayItem("CalendarInfo")]
    public Civ4CalendarInfo[]? CalendarInfos { get; set; }
}
