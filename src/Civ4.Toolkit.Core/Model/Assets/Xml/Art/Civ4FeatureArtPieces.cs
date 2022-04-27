using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4FeatureArtPieces
{
    [XmlArray("FeatureArtPieces", Order = 1)]
    [XmlArrayItem("FeatureArtPiece")]
    public Civ4FeatureArtPiece[] FeatureArtPieces { get; set; } = Array.Empty<Civ4FeatureArtPiece>();
    
    [XmlArray("FeatureDummyNodes", Order = 2)]
    [XmlArrayItem("FeatureDummyNode")]
    public Civ4FeatureDummyNode[] FeatureDummyNodes { get; set; } = Array.Empty<Civ4FeatureDummyNode>();
    
    [XmlElement("bGenerateRotations", Order = 3)]
    public byte? GenerateRotations { get; set; }

    [XmlElement("VarietyButton", Order = 4)]
    public string? VarietyButton { get; set; }
}
