using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Buildings;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.Buildings;

public class BuildingInfosTests : XmlTestBase<Civ4BuildingInfos>
{
    [TestCase(Civ4GameVariant.Vanilla, "./Buildings/CIV4BuildingInfos.xml", 100)]
    [TestCase(Civ4GameVariant.Warlords, "./Buildings/CIV4BuildingInfos.xml", 129)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Buildings/CIV4BuildingInfos.xml", 159)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.BuildingInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.BuildingInfos!.Length, expectedCount);
    }

    [TestCase(
        Civ4GameVariant.BeyondTheSword, "./Buildings/CIV4BuildingInfos.xml",
        Civ4GameVariant.BeyondTheSword, "./Buildings/CIV4BuildingsSchema.xml",
        "x-schema:CIV4BuildingsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Warlords, "./Buildings/CIV4BuildingInfos.xml",
        Civ4GameVariant.Warlords, "./Buildings/CIV4BuildingsSchema.xml",
        "x-schema:CIV4BuildingsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Vanilla, "./Buildings/CIV4BuildingInfos.xml",
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
