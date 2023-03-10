using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Text;

[XmlRoot("Civ4GameText", Namespace = "http://www.firaxis.com")]
public class Civ4GameText : Civ4AssetFile
{
    [XmlElement("TEXT")]
    public Civ4TextNode[]? TextNodes { get; set; }    
}
