using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4LeaderAvailability
{
    [XmlElement("LeaderName", Order = 1)]
    public string? LeaderName { get; set; }
    
    [XmlElement("bLeaderAvailability", Order = 2)]
    public byte? LeaderAvailability { get; set; }

    public override string ToString()
    {
        return $"Leader = {LeaderName}, bLeaderAvailability = {LeaderAvailability}";
    }
}
