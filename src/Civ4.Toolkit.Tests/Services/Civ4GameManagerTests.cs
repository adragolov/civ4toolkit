using Civ4.Toolkit.Model;
using Civ4.Toolkit.Services;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests.Services;

public class Civ4GameManagerTests
{
    [Test]
    public void InitializationSuccess()
    {
        var _ = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
    }

    [TestCase(Civ4GameVariant.Vanilla, true)]
    [TestCase(Civ4GameVariant.Warlords, true)]
    [TestCase(Civ4GameVariant.BeyondTheSword, true)]
    public void GameRootConfigured(Civ4GameVariant gameVariant, bool expectedIsConfigured)
    {
        var gameManager = TestBootstrapper.ResolveDependency<ICiv4GameManager>();
        Assert.AreEqual(gameManager.IsConfigured(gameVariant), expectedIsConfigured);
    }
}
