using System.IO;
using System.Linq;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services;

public class Civ4GameManagerTests
{
    private ICiv4GameManager GameManager = null!;
    
    [SetUp]
    public void InitializationSuccess()
    {
        GameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
    }

    [TestCase(Civ4GameVariant.Vanilla, true)]
    [TestCase(Civ4GameVariant.Warlords, true)]
    [TestCase(Civ4GameVariant.BeyondTheSword, true)]
    public void GameRootConfigured(Civ4GameVariant gameVariant, bool expectedIsConfigured)
    {
        Assert.AreEqual(GameManager.IsConfigured(gameVariant), expectedIsConfigured);

        new[]
        {
            GameManager.GetGameRoot(gameVariant),
            GameManager.GetAssetsDir(gameVariant),
            GameManager.GetAssetsXmlDir(gameVariant)
        }.ToList().ForEach(dir =>
        {
            Assert.True(Directory.Exists(dir));
        });
    }

    [TestCase(Civ4GameVariant.Vanilla, true)]
    [TestCase(Civ4GameVariant.Warlords, true)]
    [TestCase(Civ4GameVariant.BeyondTheSword, true)]
    public void GameDirectoriesExist(Civ4GameVariant gameVariant, bool expectedIsConfigured)
    {
        new[]
        {
            GameManager.GetGameRoot(gameVariant),
            GameManager.GetAssetsDir(gameVariant),
            GameManager.GetAssetsXmlDir(gameVariant)
        }.ToList().ForEach(dir =>
        {
            Assert.True(Directory.Exists(dir));
        });
    }
}
