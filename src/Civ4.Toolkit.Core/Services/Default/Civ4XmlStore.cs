using System.Text;
using System.Xml.Serialization;
using Civ4.Toolkit.Model;
using Microsoft.Extensions.Logging;

namespace Civ4.Toolkit.Services.Default;

public class Civ4XmlStore<TXmlAssetFile> : ICiv4XmlStore<TXmlAssetFile> where TXmlAssetFile : Civ4AssetFile
{
    public ILogger<ICiv4XmlStore<TXmlAssetFile>> Logger { get; }

    public Civ4XmlStore(ILogger<ICiv4XmlStore<TXmlAssetFile>> logger)
    {
        Logger = logger;
    }

    public async Task<TXmlAssetFile> LoadAsync(
        string xmlPath,
        CancellationToken cancellationToken = default)
    {
        var start = DateTimeOffset.Now;
        Logger.LogDebug("Parsing XML asset file '{XmlAssetFile}' into object of type '{XmlAssetType}'",
            xmlPath,
            typeof(TXmlAssetFile));
        
        if (!File.Exists(xmlPath))
        {
            throw new FileNotFoundException(
                $"File '{xmlPath}' not found.");
        }
        
        await using var stream = File.OpenRead(xmlPath);
        var serializer = new XmlSerializer(typeof(TXmlAssetFile));

        serializer.UnknownAttribute += (sender, args) =>
        {
            Logger.LogWarning("File {XmlAssetFile}, Line {LineNumber}, Position {LineSymbol}," +
                              "Unknown attribute {XmlAttributeName}.",
                xmlPath,
                args.LineNumber,
                args.LinePosition,
                args.Attr.Name);
        };
        
        serializer.UnknownElement += (sender, args) =>
        {
            Logger.LogWarning("File {XmlAssetFile}, Line {LineNumber}, Position {LineSymbol}," +
                              "Unknown element {XmlElementName}.",
                xmlPath,
                args.LineNumber,
                args.LinePosition,
                args.Element.Name);
        };
        
        serializer.UnknownNode += (sender, args) =>
        {
            Logger.LogWarning("File {XmlAssetFile}, Line {LineNumber}, Position {LineSymbol}," +
                              "Unknown node {XmlNodeName} / {XmlNodeType}.",
                xmlPath,
                args.LineNumber,
                args.LinePosition,
                args.Name,
                args.NodeType);
        };
        
        serializer.UnreferencedObject += (sender, args) =>
        {
            Logger.LogWarning("File {XmlAssetFile}, Unreferenced object " +
                              "{UnreferencedId} / {UnreferencedObject}.",
                xmlPath,
                args.UnreferencedId,
                args.UnreferencedObject);
        };
        
        var result = (TXmlAssetFile)serializer.Deserialize(stream)!;
        result.FilePath = xmlPath;
        
        var finish = DateTimeOffset.Now;
        Logger.LogDebug("File {XmlAssetFile} parsed in {XmlAssetParseDuration} ms",
            xmlPath,
            (finish - start).TotalMilliseconds);
        
        return result;
    }
}