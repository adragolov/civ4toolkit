using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4TrailDefinition
{
    [XmlElement("Texture", Order = 1)]
    public string? Texture { get; set; }

    [XmlElement("fWidth", Order = 2)]
    public float? Width { get; set; }

    [XmlElement("fLength", Order = 3)]
    public float? Length { get; set; }

    [XmlElement("fTaper", Order = 4)]
    public float? Taper { get; set; }

    [XmlElement("fFadeStartTime", Order = 5)]
    public float? FadeStartTime { get; set; }

    [XmlElement("fFadeFalloff", Order = 6)]
    public float? FadeFalloff { get; set; }

    public override string ToString()
    {
        return $"TrailDefinition = {Texture}";
    }
}