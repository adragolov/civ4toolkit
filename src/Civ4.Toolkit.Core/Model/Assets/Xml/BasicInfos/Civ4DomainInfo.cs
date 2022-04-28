using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.BasicInfos;

public class Civ4DomainInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Description", Order = 2)]
    public string? Description { get; set; }
    
    public override string ToString()
    {
        return $"DomainInfo = {Type}";
    }
}
