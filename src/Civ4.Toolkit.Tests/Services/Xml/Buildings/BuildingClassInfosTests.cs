using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Buildings;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.Buildings;

public class BuildingClassInfosTests : XmlTestBase<Civ4BuildingClassInfos>
{
    [TestCase(Civ4GameVariant.Vanilla, "./Buildings/CIV4BuildingClassInfos.xml", 100)]
    [TestCase(Civ4GameVariant.Warlords, "./Buildings/CIV4BuildingClassInfos.xml", 105)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Buildings/CIV4BuildingClassInfos.xml", 125)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.BuildingClassInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.BuildingClassInfos!.Length, expectedCount);
    }

    [TestCase(
        Civ4GameVariant.BeyondTheSword, "./Buildings/CIV4BuildingClassInfos.xml",
        Civ4GameVariant.BeyondTheSword, "./Buildings/CIV4BuildingsSchema.xml",
        "x-schema:CIV4BuildingsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Warlords, "./Buildings/CIV4BuildingClassInfos.xml",
        Civ4GameVariant.Warlords, "./Buildings/CIV4BuildingsSchema.xml",
        "x-schema:CIV4BuildingsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Vanilla, "./Buildings/CIV4BuildingClassInfos.xml",
        Civ4GameVariant.Vanilla, "./Buildings/CIV4BuildingsSchema.xml",
        "x-schema:CIV4BuildingsSchema.xml")]
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
