using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml;

[TestFixture]
public class ParseGlobalDefinesTests
{
    private ICiv4XmlStore<Civ4Defines> XmlStore = null!;
    private ICiv4GameManager GameManager = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4Defines>>();
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
}
