using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.BasicInfos;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.BasicInfos;

public class BasicInfosTests : XmlTestBase<Civ4BasicInfos>
{
    [TestCase(Civ4GameVariant.Vanilla, "./BasicInfos/CIV4BasicInfos.xml", 48)]
    [TestCase(Civ4GameVariant.Warlords, "./BasicInfos/CIV4BasicInfos.xml", 51)]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./BasicInfos/CIV4BasicInfos.xml", 50)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.ConceptInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.ConceptInfos!.Length, expectedCount);
    }
}
