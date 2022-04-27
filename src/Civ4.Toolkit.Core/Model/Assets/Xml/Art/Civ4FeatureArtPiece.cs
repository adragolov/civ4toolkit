using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4FeatureArtPiece
{
    [XmlElement("ModelFile")]
    public string[] ModelFiles { get; set; } = Array.Empty<string>();
    
    [XmlElement("Connections")]
    public string? Connections { get; set; }

    public override string ToString()
    {
        return $"FeatureArtPeace, Connections = {Connections}";
    }
}
