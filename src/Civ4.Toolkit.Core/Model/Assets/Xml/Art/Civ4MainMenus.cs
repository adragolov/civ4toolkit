using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

[XmlRoot("Civ4MainMenus", Namespace = "x-schema:CIV4ArtDefinesSchema.xml")]
public class Civ4MainMenus : Civ4AssetFile
{
    [XmlArray("MainMenus")]
    [XmlArrayItem("MainMenu")]
    public Civ4MainMenu[]? MainMenus { get; set; }
}
