
using System;
using System.IO;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Art;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.XmlStore.Art;

public class ParseCiv4ArtDefinesLeaderheadArtInfosTests
{
    private ICiv4XmlStore<Civ4ArtDefinesLeaderheadArtInfos> XmlStore = null!;
    private ICiv4GameManager GameManager = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4ArtDefinesLeaderheadArtInfos>>();
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./Art/CIV4ArtDefines_Leaderhead.xml", 27)]
    [TestCase(Civ4GameVariant.Warlords, "./Art/CIV4ArtDefines_Leaderhead.xml", 37)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Art/CIV4ArtDefines_Leaderhead.xml", 53)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.LeaderheadArtInfo);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.LeaderheadArtInfo!.Length, expectedCount);
    }
}
