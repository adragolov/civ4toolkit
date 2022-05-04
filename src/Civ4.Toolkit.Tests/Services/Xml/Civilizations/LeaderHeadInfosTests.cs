using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Civilizations;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.Civilizations;

public class LeaderHeadInfosTests : XmlTestBase<Civ4LeaderHeadInfos>
{
    [TestCase(Civ4GameVariant.Vanilla, "./Civilizations/CIV4LeaderHeadInfos.xml", 27)]
    [TestCase(Civ4GameVariant.Warlords, "./Civilizations/CIV4LeaderHeadInfos.xml", 37)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Civilizations/CIV4LeaderHeadInfos.xml", 53)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.LeaderHeadInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.LeaderHeadInfos!.Length, expectedCount);
    }
    
    [TestCase(
        Civ4GameVariant.BeyondTheSword, "./Civilizations/CIV4LeaderHeadInfos.xml",
        Civ4GameVariant.BeyondTheSword, "./Civilizations/CIV4CivilizationsSchema.xml",
        "x-schema:CIV4CivilizationsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Warlords, "./Civilizations/CIV4LeaderHeadInfos.xml",
        Civ4GameVariant.Warlords, "./Civilizations/CIV4CivilizationsSchema.xml",
        "x-schema:CIV4CivilizationsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Vanilla, "./Civilizations/CIV4LeaderHeadInfos.xml",
        Civ4GameVariant.Vanilla, "./Civilizations/CIV4CivilizationsSchema.xml",
        "x-schema:CIV4CivilizationsSchema.xml")]
    public void ValidateWithSchema(
        Civ4GameVariant xmlGameVariant,
        string xmlRelativePath,
        Civ4GameVariant xdrGameVariant,
        string xdrRelativePath,
        string targetNamespace)
    {
        ValidateXdr(xmlGameVariant, xmlRelativePath, xdrGameVariant, xdrRelativePath, targetNamespace);
    }
}
