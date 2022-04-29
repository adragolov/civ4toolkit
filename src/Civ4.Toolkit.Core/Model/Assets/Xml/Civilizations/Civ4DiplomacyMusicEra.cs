using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4DiplomacyMusicEra
{
    [XmlElement("EraType", Order = 1)]
    public string? EraType { get; set; }
    
    [XmlElement("DiploScriptId", Order = 2)]
    public string? DiplomacyScriptId { get; set; }

    public override string ToString()
    {
        return $"DiplomacyMusicEra = {EraType}, DiplomacyScriptId = {DiplomacyScriptId}";
    }
}