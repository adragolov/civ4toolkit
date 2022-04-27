using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4TerrainArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Path", Order = 2)]
    public string? Path { get; set; }
    
    [XmlElement("Grid", Order = 3)]
    public string? Grid { get; set; }
    
    [XmlElement("Detail", Order = 4)]
    public string? Detail { get; set; }
    
    [XmlElement("Button", Order = 5)]
    public string? Button { get; set; }
    
    [XmlElement("LayerOrder", Order = 6)]
    public int? LayerOrder { get; set; }
    
    [XmlElement("AlphaShader", Order = 7)]
    public int? AlphaShader { get; set; }
    
    [XmlElement("TextureBlend01", Order = 8)]
    public string? TextureBlend01 { get; set; }
    
    [XmlElement("TextureBlend02", Order = 9)]
    public string? TextureBlend02 { get; set; }
    
    [XmlElement("TextureBlend04", Order = 10)]
    public string? TextureBlend04 { get; set; }
    
    [XmlElement("TextureBlend08", Order = 11)]
    public string? TextureBlend08 { get; set; }
    
    [XmlElement("TextureBlend03", Order = 12)]
    public string? TextureBlend03 { get; set; }
    
    [XmlElement("TextureBlend06", Order = 13)]
    public string? TextureBlend06 { get; set; }
    
    [XmlElement("TextureBlend12", Order = 14)]
    public string? TextureBlend12 { get; set; }
    
    [XmlElement("TextureBlend09", Order = 15)]
    public string? TextureBlend09 { get; set; }
    
    [XmlElement("TextureBlend07", Order = 16)]
    public string? TextureBlend07 { get; set; }
    
    [XmlElement("TextureBlend14", Order = 17)]
    public string? TextureBlend14 { get; set; }
    
    [XmlElement("TextureBlend13", Order = 18)]
    public string? TextureBlend13 { get; set; }
    
    [XmlElement("TextureBlend11", Order = 19)]
    public string? TextureBlend11 { get; set; }
    
    [XmlElement("TextureBlend10", Order = 20)]
    public string? TextureBlend10 { get; set; }
    
    [XmlElement("TextureBlend05", Order = 21)]
    public string? TextureBlend05 { get; set; }
    
    [XmlElement("TextureBlend15", Order = 22)]
    public string? TextureBlend15 { get; set; }

    public override string ToString()
    {
        return $"TerrainArtInfo = {Type}";
    }
}