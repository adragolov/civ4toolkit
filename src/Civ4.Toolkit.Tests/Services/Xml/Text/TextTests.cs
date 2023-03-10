using System;
using System.IO;
using System.Linq;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml.Civilizations;
using Civ4.Toolkit.Model.Assets.Xml.Text;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services.Xml.Text;

public class TextTests : XmlTestBase<Civ4GameText>
{
    [TestCase(Civ4GameVariant.BeyondTheSword, "./Text/CIV4GameText_BTS_Fixed.xml", 11)]
    public void VerifyCounts(
        Civ4GameVariant gameVariant,
        string xmlRelativePath,
        int expectedCount)
    {
        var assetPath = GameManager.GetAssetXmlFilepath(gameVariant, xmlRelativePath);
        var parsed = XmlStore.LoadAsync(assetPath).Result;
        Assert.NotNull(parsed);
        Assert.NotNull(parsed.TextNodes);
        Assert.AreEqual(parsed.FilePath, assetPath);
        Assert.AreEqual(parsed.TextNodes!.Length, expectedCount);
    }
}
