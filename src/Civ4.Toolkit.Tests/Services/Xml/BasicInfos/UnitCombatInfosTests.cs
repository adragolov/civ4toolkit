using System;
using System.IO;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.BasicInfos;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.BasicInfos;

public class UnitCombatInfosTests : XmlTestBase<Civ4UnitCombatInfos>
{
    [TestCase(Civ4GameVariant.BeyondTheSword, "./BasicInfos/CIV4UnitCombatInfos.xml", 10)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.UnitCombatInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.UnitCombatInfos!.Length, expectedCount);
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./BasicInfos/CIV4UnitCombatInfos.xml")]
    [TestCase(Civ4GameVariant.Warlords, "./BasicInfos/CIV4UnitCombatInfos.xml")]
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