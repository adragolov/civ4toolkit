using System;
using System.IO;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Civilizations;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.Civilizations;

public class TraitInfosTests : XmlTestBase<Civ4TraitInfos>
{
    [TestCase(Civ4GameVariant.Vanilla, "./Civilizations/CIV4TraitInfos.xml", 8)]
    [TestCase(Civ4GameVariant.Warlords, "./Civilizations/CIV4TraitInfos.xml", 11)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.TraitInfos);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.TraitInfos!.Length, expectedCount);
    }
    
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Civilizations/CIV4TraitInfos.xml")]
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
    
    [TestCase(
        Civ4GameVariant.Warlords, "./Civilizations/CIV4TraitInfos.xml",
        Civ4GameVariant.Warlords, "./Civilizations/CIV4CivilizationsSchema.xml",
        "x-schema:CIV4CivilizationsSchema.xml")]
    [TestCase(
        Civ4GameVariant.Vanilla, "./Civilizations/CIV4TraitInfos.xml",
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
