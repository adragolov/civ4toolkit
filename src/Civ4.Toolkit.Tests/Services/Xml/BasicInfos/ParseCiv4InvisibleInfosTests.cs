using System;
using System.IO;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.BasicInfos;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.BasicInfos;

public class ParseCiv4InvisibleInfosTests
{
    private ICiv4XmlStore<Civ4InvisibleInfos> XmlStore = null!;
    private ICiv4GameManager GameManager = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4InvisibleInfos>>();
    }
    
    [TestCase(Civ4GameVariant.BeyondTheSword, "./BasicInfos/CIV4InvisibleInfos.xml", 2)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.InvisibleInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.InvisibleInfos!.Length, expectedCount);
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./BasicInfos/CIV4InvisibleInfos.xml")]
    [TestCase(Civ4GameVariant.Warlords, "./BasicInfos/CIV4InvisibleInfos.xml")]
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