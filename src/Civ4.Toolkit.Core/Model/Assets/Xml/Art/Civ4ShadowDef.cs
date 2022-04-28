using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4ShadowDef
{
    [XmlElement("ShadowNIF", Order = 1)]
    public string? ShadowNIF { get; set; }
    
    [XmlElement("ShadowAttachNode", Order = 2)]
    public string? ShadowAttachNode { get; set; }
    
    [XmlElement("fShadowScale", Order = 3)]
    public float? ShadowScale { get; set; }

    public override string ToString()
    {
        return $"ShadowDef = {ShadowNIF}";
    }
}