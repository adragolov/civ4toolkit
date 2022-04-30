using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Civilizations;

public class Civ4FreePromotion
{
    [XmlElement("PromotionType", Order = 1)]
    public string? PromotionType { get; set; }
    
    [XmlElement("bFreePromotion", Order = 2)]
    public byte? Enabled { get; set; }

    public override string ToString()
    {
        return $"FreePromotion = {PromotionType}, bFreePromotion = {Enabled}";
    }
}