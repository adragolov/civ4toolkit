using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4RouteModelInfo
{
    [XmlElement("ModelFile", Order = 1)]
    public string? ModelFile { get; set; }
    
    [XmlElement("LateModelFile", Order = 2)]
    public string? LateModelFile { get; set; }
    
    [XmlElement("ModelFileKey", Order = 3)]
    public string? ModelFileKey { get; set; }
    
    [XmlElement("Animated", Order = 4)]
    public int? Animated { get; set; }
    
    [XmlElement("RouteType", Order = 5)]
    public string? RouteType { get; set; }
    
    [XmlElement("Connections", Order = 6)]
    public string? Connections { get; set; }
    
    [XmlElement("ModelConnections", Order = 7)]
    public string? ModelConnections { get; set; }
    
    [XmlElement("Rotations", Order = 8)]
    public string? Rotations { get; set; }

    public override string ToString()
    {
        return $"RouteModelInfo = {ModelFile}";
    }
}