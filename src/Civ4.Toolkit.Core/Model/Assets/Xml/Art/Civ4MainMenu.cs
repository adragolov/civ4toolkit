using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4MainMenu
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    [XmlElement("Scene", Order = 3)]
    public string? Scene { get; set; }
    
    [XmlElement("SceneNoShader", Order = 4)]
    public string? SceneNoShader { get; set; }
    
    [XmlElement("Soundtrack", Order = 5)]
    public string? Soundtrack { get; set; }
    
    [XmlElement("Loading", Order = 6)]
    public string? Loading { get; set; }
    
    [XmlElement("LoadingSlideshow", Order = 7)]
    public string? LoadingSlideshow { get; set; }

    public override string ToString()
    {
        return $"MainMenu = {Type}";
    }
}