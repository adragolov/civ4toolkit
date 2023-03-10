using System.Collections;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Text;

public class Civ4TextNode
{
    [XmlElement("Tag", Order = 1)]
    public string? Tag { get; set; }
    
    [XmlElement("English", typeof(string), Order = 2)]
    public object? EnglishNode { get; set; }
    [XmlElement("French", Order = 3)]
    public object? FrenchNode { get; set; }
    [XmlElement("German", typeof(Civ4TextExtendedInfo), Order = 4)]
    public Civ4TextExtendedInfo? GermanNode { get; set; }
    /*
    [XmlElement("French", Order = 3)]
    public string? FrenchNode { get; set; }
    
    [XmlElement("German", Order = 4)]
    public string? GermanNode { get; set; }
    
    [XmlElement("Italian", Order = 5)]
    public string? ItalianNode { get; set; }
    
    [XmlElement("Spanish", Order = 6)]
    public string? SpanishNode { get; set; }*/
}

public class Civ4TextExtendedInfo : IXmlSerializable
{
    //[XmlElement("Text", Order = 1, Type = typeof(string))]
    public string? Text { get; set; }
    //[XmlElement("Gender", Order = 2, Type = typeof(string))]
    public string? Gender { get; set; }
    //[XmlElement("Plural", Order = 3, Type = typeof(string))]
    public string? Plural { get; set; }

    public XmlSchema? GetSchema()
    {
        return null;
    }

    public void ReadXml(XmlReader reader)
    {
        var innerXml = reader.ReadInnerXml();

        if (innerXml.StartsWith("<Text xmlns"))
        {
            var matches = Regex.Matches(innerXml, "<(.*?)>(.*?)</(.*?)>");
            if (matches.Count > 0)
            {
            }
        }
        else
        {
            Text = innerXml;
        }
    }

    public void WriteXml(XmlWriter writer)
    {
    }
}