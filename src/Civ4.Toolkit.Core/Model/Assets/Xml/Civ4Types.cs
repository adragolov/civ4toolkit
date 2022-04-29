using System;
using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml;

[XmlRoot(nameof(Civ4Types), Namespace = "x-schema:CIV4GlobalTypesSchema.xml")]
public class Civ4Types : Civ4AssetFile
{
    [XmlArray("AnimationOperatorTypes", Order = 1)]
    [XmlArrayItem("AnimationOperatorType", typeof(string))]
    public string[] AnimationOperatorTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("FunctionTypes", Order = 2)]
    [XmlArrayItem("FunctionType", typeof(string))]
    public string[] FunctionTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("FlavorTypes", Order = 3)]
    [XmlArrayItem("FlavorType", typeof(string))]
    public string[] FlavorTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("ArtStyleTypes", Order = 4)]
    [XmlArrayItem("ArtStyleType", typeof(string))]
    public string[] ArtStyleTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("CitySizeTypes", Order = 5)]
    [XmlArrayItem("CitySizeType", typeof(string))]
    public string[] CitySizeTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("ContactTypes", Order = 6)]
    [XmlArrayItem("ContactType", typeof(string))]
    public string[] ContactTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("DiplomacyPowerTypes", Order = 7)]
    [XmlArrayItem("DiplomacyPowerType", typeof(string))]
    public string[] DiplomacyPowerTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("AutomateTypes", Order = 8)]
    [XmlArrayItem("AutomateType", typeof(string))]
    public string[] AutomateTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("DirectionTypes", Order = 9)]
    [XmlArrayItem("DirectionType", typeof(string))]
    public string[] DirectionTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("FootstepAudioTypes", Order = 10)]
    [XmlArrayItem("FootstepAudioType", typeof(string))]
    public string[] FootstepAudioTypes { get; set; } = Array.Empty<string>();
    
    [XmlArray("FootstepAudioTags", Order = 11)]
    [XmlArrayItem("FootstepAudioTag", typeof(Civ4TypeFootstepAudioTag))]
    public Civ4TypeFootstepAudioTag[] FootstepAudioTags { get; set; } = Array.Empty<Civ4TypeFootstepAudioTag>();
    
    [XmlArray("InterfaceVisibilityTypes", Order = 12)]
    [XmlArrayItem("InterfaceVisibilityType", typeof(string))]
    public string[] InterfaceVisibilityTypes { get; set; } = Array.Empty<string>();
}
