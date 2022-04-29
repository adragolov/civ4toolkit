
using System;
using System.IO;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Art;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.Art;

public class ParseCiv4ArtDefinesMiscArtInfosTests
{
    private ICiv4XmlStore<Civ4ArtDefinesMiscArtInfos> XmlStore = null!;
    private ICiv4GameManager GameManager = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4ArtDefinesMiscArtInfos>>();
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./Art/CIV4ArtDefines_Misc.xml", 36)]
    [TestCase(Civ4GameVariant.Warlords, "./Art/CIV4ArtDefines_Misc.xml", 40)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Art/CIV4ArtDefines_Misc.xml", 48)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.MiscArtInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.MiscArtInfos!.Length, expectedCount);
    }
}
