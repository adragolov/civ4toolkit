using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

[XmlRoot("Civ4CivilizationInfos", Namespace = "x-schema:CIV4CivilizationsSchema.xml")]
public class Civ4CivilizationInfos: Civ4AssetFile
{
    [XmlArray("CivilizationInfos")]
    [XmlArrayItem("CivilizationInfo")]
    public Civ4CivilizationInfo[]? CivilizationInfos { get; set; }
}
