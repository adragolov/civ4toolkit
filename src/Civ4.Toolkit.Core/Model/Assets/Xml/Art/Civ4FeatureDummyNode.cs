using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4FeatureDummyNode
{
    [XmlElement("Tag", Order = 1)]
    public string? Tag { get; set; }

    [XmlElement("Name", Order = 2)]
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"{Tag}, Name = {Name}";
    }
}
