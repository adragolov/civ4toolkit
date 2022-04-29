using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml;

[TestFixture]
public class GlobalTypesTests : XmlTestBase
{
    private ICiv4XmlStore<Civ4Types> XmlStore = null!;

    [OneTimeSetUp]
    public void Setup()
    {
        XmlStore = TestBootstrapper.ResolveDependency<ICiv4XmlStore<Civ4Types>>();
    }
    
    [TestCase(Civ4GameVariant.Vanilla, "./GlobalTypes.xml")]
    [TestCase(Civ4GameVariant.Warlords, "./GlobalTypes.xml")]
    [TestCase(Civ4GameVariant.BeyondTheSword, "./GlobalTypes.xml")]
    public void VerifyGlobalTypes(
        Civ4GameVariant gameVariant,
        string xmlRelativePath)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.NotNull(parsed.AnimationOperatorTypes);
        Assert.NotNull(parsed.AutomateTypes);
        Assert.NotNull(parsed.ContactTypes);
        Assert.NotNull(parsed.DirectionTypes);
        Assert.NotNull(parsed.FlavorTypes);
        Assert.NotNull(parsed.FunctionTypes);
        Assert.NotNull(parsed.ArtStyleTypes);
        Assert.NotNull(parsed.CitySizeTypes);
        Assert.NotNull(parsed.DiplomacyPowerTypes);
        Assert.NotNull(parsed.FootstepAudioTypes);
        Assert.NotNull(parsed.FootstepAudioTags);
        Assert.NotNull(parsed.InterfaceVisibilityTypes);
    }
    
    [TestCase(
        Civ4GameVariant.BeyondTheSword, "./GlobalTypes.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalTypesSchema.xml",
        "x-schema:CIV4GlobalTypesSchema.xml")]
    [TestCase(
        Civ4GameVariant.Warlords, "./GlobalTypes.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalTypesSchema.xml",
        "x-schema:CIV4GlobalTypesSchema.xml")]
    [TestCase(
        Civ4GameVariant.Vanilla, "./GlobalTypes.xml",
        Civ4GameVariant.Vanilla, "./CIV4GlobalTypesSchema.xml",
        "x-schema:CIV4GlobalTypesSchema.xml")]
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
