using System.Linq;
using System.Xml;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml;

public abstract class XmlTestBase<TXmlFileAsset> where TXmlFileAsset: Civ4AssetFile
{
    protected ICiv4XmlStore<TXmlFileAsset> XmlStore = null!;
    protected ICiv4GameManager GameManager = null!;
    protected ICiv4XmlValidator XmlValidator = null!;

    [OneTimeSetUp]
    protected virtual void OneTimeDependencyInjection()
    {
        GameManager = TestBootstrapper.ResolveGameManager();
        XmlValidator = TestBootstrapper.ResolveXmlValidator();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<TXmlFileAsset>>();
    }
    
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
        Assert.NotNull(validationResult.XdrFile);
        Assert.AreEqual(validationResult.XdrFile, xdrFilepath);
#pragma warning disable CS0618
        Assert.True(validationResult.ValidationType == ValidationType.XDR);
#pragma warning restore CS0618
        Assert.NotNull(validationResult.Errors);
        Assert.AreEqual(validationResult.Errors.Count(), 0);
        Assert.NotNull(validationResult.Warnings);
        Assert.AreEqual(validationResult.Warnings.Count(), 0);
    }
}
