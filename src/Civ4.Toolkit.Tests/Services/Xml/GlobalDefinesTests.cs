using System.Linq;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml;

[TestFixture]
public class GlobalDefinesTests
{
    private ICiv4XmlValidator xmlValidator = null!;
    private ICiv4XmlStore<Civ4Defines> XmlStore = null!;
    private ICiv4GameManager GameManager = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4Defines>>();
        xmlValidator = TestBootstrapper.ResolveDependency<ICiv4XmlValidator>();
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./GlobalDefines.xml", 294)]
    [TestCase(Civ4GameVariant.Warlords, "./GlobalDefines.xml", 311)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./GlobalDefines.xml", 405)]
    public void VerifyGlobalDefinesCount(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedDefinesCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.Defines);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.Defines.Length, expectedDefinesCount);
    }

    [TestCase(
        Civ4GameVariant.Vanilla, "./GlobalDefines.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalDefinesSchema.xml",
        "x-schema:CIV4GlobalDefinesSchema.xml")]
    [TestCase(
        Civ4GameVariant.Vanilla, "./GlobalDefinesAlt.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalDefinesSchema.xml",
        "x-schema:CIV4GlobalDefinesSchema.xml")]
    [TestCase(
        Civ4GameVariant.Warlords, "./GlobalDefines.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalDefinesSchema.xml",
        "x-schema:CIV4GlobalDefinesSchema.xml")]
    [TestCase(
        Civ4GameVariant.BeyondTheSword, "./GlobalDefines.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalDefinesSchema.xml",
        "x-schema:CIV4GlobalDefinesSchema.xml")]
    public void ValidateWithSchema(
        Civ4GameVariant xmlGameVariant,
        string xmlRelativePath,
        Civ4GameVariant xdrGameVariant,
        string xdrRelativePath,
        string targetNamespace)
    {
        var xmlFilepath = GameManager.GetAssetXmlFilepath(xmlGameVariant, xmlRelativePath);
        var xdrFilepath = GameManager.GetAssetXmlFilepath(xdrGameVariant, xdrRelativePath);

        var validationResult = xmlValidator.ValidateUsingXdrAsync(
            xmlFilepath, targetNamespace, xdrFilepath).Result;
        
        Assert.NotNull(validationResult);
        Assert.True(validationResult.IsValid);
        Assert.NotNull(validationResult.Errors);
        Assert.AreEqual(validationResult.Errors.Count(), 0);
        Assert.NotNull(validationResult.Warnings);
        Assert.AreEqual(validationResult.Warnings.Count(), 0);
    }
}
