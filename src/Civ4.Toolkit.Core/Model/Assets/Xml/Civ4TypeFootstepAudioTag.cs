using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml;

public class Civ4TypeFootstepAudioTag
{
    [XmlElement("FootstepAudioType", Order = 0)]
    public string? FootstepAudioType { get; set; }

    [XmlElement("FootstepAudioTagString", Order = 1)]
    public string? FootstepAudioTagString { get; set; }

    public override string ToString()
    {
        return $"{FootstepAudioType}, FootstepAudioTagString = {FootstepAudioTagString}";
    }
}