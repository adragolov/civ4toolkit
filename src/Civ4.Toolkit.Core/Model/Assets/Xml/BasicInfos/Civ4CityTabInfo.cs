using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

public class Civ4CityTabInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    [XmlElement("Button", Order = 3)]
    public string? Button { get; set; }
    
    public override string ToString()
    {
        return $"CityTabInfo = {Type}";
    }
}
