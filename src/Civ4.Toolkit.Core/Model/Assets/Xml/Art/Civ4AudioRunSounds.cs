using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4AudioRunSounds
{
    [XmlElement("AudioRunTypeLoop", Order = 1)]
    public string? AudioRunTypeLoop { get; set; }
 
    [XmlElement("AudioRunTypeEnd", Order = 2)]
    public string? AudioRunTypeEnd { get; set; }
    
    public override string ToString()
    {
        return $"AudioRunSounds Loop = {AudioRunTypeLoop}, End = {AudioRunTypeEnd}";
    }
}
