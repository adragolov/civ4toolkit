
using System;
using System.IO;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Art;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.XmlStore.Art;

public class ParseCiv4MainMenusTests
{
    private ICiv4XmlStore<Civ4MainMenus> XmlStore = null!;
    private ICiv4GameManager GameManager = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4MainMenus>>();
    }
    
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Art/CIV4MainMenus.xml", 4)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.MainMenus);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.MainMenus!.Length, expectedCount);
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./Art/CIV4MainMenus.xml")]
    [TestCase(Civ4GameVariant.Warlords, "./Art/CIV4MainMenus.xml")]
    public void ExpectFileNotFound(
        Civ4GameVariant gameVariant,
        string xmlRelativePath)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);

        try
        {
            var _ = XmlStore.LoadAsync(assetPath).Result;
            Assert.Fail($"File is expected not to exist: {assetPath}.");
        }
        catch (AggregateException exception)
        {
            Assert.IsNotNull(exception.InnerException);
            Assert.True(exception.InnerException is FileNotFoundException);
        }
    }
}
