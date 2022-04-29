using System.Linq;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml;

public abstract class XmlTestBase
{
    protected ICiv4GameManager GameManager = TestBootstrapper.ResolveGameManager();
    protected ICiv4XmlValidator XmlValidator = TestBootstrapper.ResolveXmlValidator();

    protected void ValidateXdr(
        Civ4GameVariant xmlGameVariant,
        string xmlRelativePath,
        Civ4GameVariant xdrGameVariant,
        string xdrRelativePath,
        string targetNamespace)
    {
        var xmlFilepath = GameManager.GetAssetXmlFilepath(xmlGameVariant, xmlRelativePath);
        var xdrFilepath = GameManager.GetAssetXmlFilepath(xdrGameVariant, xdrRelativePath);

        var validationResult = XmlValidator.ValidateUsingXdrAsync(
            xmlFilepath, targetNamespace, xdrFilepath).Result;
        
        Assert.NotNull(validationResult);
        Assert.True(validationResult.IsValid);
        Assert.NotNull(validationResult.Errors);
        Assert.AreEqual(validationResult.Errors.Count(), 0);
        Assert.NotNull(validationResult.Warnings);
        Assert.AreEqual(validationResult.Warnings.Count(), 0);
    }
}
