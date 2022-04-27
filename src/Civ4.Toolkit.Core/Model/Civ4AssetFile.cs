using System.Xml.Serialization;

namespace Civ4.Toolkit.Model;

public class Civ4AssetFile
{
    [XmlIgnore]
    public string? FilePath { get; set; }

    public override string ToString()
    {
        return $"{GetType().Name}, FilePath = {FilePath}";
    }
}