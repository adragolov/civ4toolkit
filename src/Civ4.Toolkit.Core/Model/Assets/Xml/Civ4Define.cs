using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml;

public class Civ4Define
{
    [XmlElement("DefineName", Order = 0)]
    public string? DefineName { get; set; }
    
    [XmlElement("iDefineIntVal", Order = 1)]
    public int? IntValue { get; set; }
    
    [XmlElement("fDefineFloatVal", Order = 2)]
    public float? FloatValue { get; set; }
    
    [XmlElement("DefineTextVal", Order = 3)]
    public string? TextValue { get; set; }

    [XmlIgnore]
    public object? Value
    {
        get
        {
            if (IntValue.HasValue) return IntValue;
            if (FloatValue.HasValue) return FloatValue;
            return TextValue;
        }
    }

    public override string ToString()
    {
        return $"Define {DefineName}, Value = {Value}";
    }
}
