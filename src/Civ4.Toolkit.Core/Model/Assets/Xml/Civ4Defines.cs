using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml;

[XmlRoot(nameof(Civ4Defines), Namespace = "x-schema:CIV4GlobalDefinesSchema.xml")]
public class Civ4Defines : Civ4AssetFile
{
    [XmlElement("Define")]
    public Civ4Define[] Defines { get; set; } = Array.Empty<Civ4Define>();
}