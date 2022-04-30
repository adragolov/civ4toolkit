using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

[XmlRoot("Civ4TraitInfos", Namespace = "x-schema:CIV4CivilizationsSchema.xml")]
public class Civ4TraitInfos : Civ4AssetFile
{
    [XmlArray("TraitInfos")]
    [XmlArrayItem("TraitInfo")]
    public Civ4TraitInfo[]? TraitInfos { get; set; }
}
