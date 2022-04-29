using System.Xml;
using System.Xml.Schema;
using Civ4.Toolkit.Model;
using Microsoft.Extensions.Logging;

namespace Civ4.Toolkit.Services.Default;

public class Civ4XmlValidator : ICiv4XmlValidator
{
    public ILogger<ICiv4XmlValidator> Logger { get; }

    public Civ4XmlValidator(ILogger<ICiv4XmlValidator> logger)
    {
        Logger = logger;
    }

    public Task<Civ4AssetFileValidationResult> ValidateUsingXdrAsync(
        string xmlFile,
        string targetNamespace,
        string xdrFile,
        CancellationToken cancellationToken = default)
    {
        if (!File.Exists(xmlFile))
        {
            throw new FileNotFoundException(
                $"XML file '{xmlFile}' not found.");
        }

        if (!File.Exists(xdrFile))
        {
            throw new FileNotFoundException(
                $"XML file '{xdrFile}' not found.");
        }
        
        using var xmlReader = new XmlTextReader(xmlFile);
#pragma warning disable CS0618
        using var xmlValidationReader = new XmlValidatingReader(xmlReader);
#pragma warning restore CS0618

        var warnings = new List<string>();
        var errors = new List<string>();

        xmlValidationReader.Schemas.Add(targetNamespace, xdrFile);
#pragma warning disable CS0618
        xmlValidationReader.ValidationType = ValidationType.XDR;
#pragma warning restore CS0618
        xmlValidationReader.ValidationEventHandler += (_, args) =>
        {
            if (args.Severity == XmlSeverityType.Warning)
            {
                warnings.Add($"{args.Message}, Exception = {args.Exception}");
                Logger.LogWarning("{ValidationMessage}, Exception = {Exception}",
                    args.Message,
                    args.Exception.ToString());
            }
            else
            {
                errors.Add($"{args.Message}, Exception = {args.Exception}");
                Logger.LogError("{ValidationMessage}, Exception = {Exception}",
                    args.Message,
                    args.Exception.ToString());
            }
        };

        while(xmlValidationReader.Read())
        {
        }

        return Task.FromResult(new Civ4AssetFileValidationResult
        {
            XdrFile = xdrFile,
            ValidationType = xmlValidationReader.ValidationType,
            Warnings = warnings,
            Errors = errors,
        });
    }
}
