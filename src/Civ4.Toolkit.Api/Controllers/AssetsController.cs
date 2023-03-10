using Civ4.Toolkit.Model;
using Civ4.Toolkit.Model.Assets.Xml;
using Civ4.Toolkit.Model.Assets.Xml.Civilizations;
using Civ4.Toolkit.Services;
using Microsoft.AspNetCore.Mvc;

namespace Civ4.Toolkit.Api.Controllers;

public class AssetsController : ControllerBase
{
    public ICiv4GameManager GameManager { get; }
    public ICiv4XmlStore<Civ4Types> GlobalTypesStore { get; }
    public ICiv4XmlStore<Civ4Defines> GlobalDefinesStore { get; }
    public ICiv4XmlStore<Civ4CivilizationInfos> CivilizationInfosStore { get; }
    public ICiv4XmlStore<Civ4LeaderHeadInfos> CivilizationLeaderHeadInfosStore { get; }
    public ICiv4XmlStore<Civ4TraitInfos> CivilizationTraitInfosStore { get; }

    public AssetsController(
        ICiv4GameManager gameManager,
        ICiv4XmlStore<Civ4Types> globalTypesStore,
        ICiv4XmlStore<Civ4Defines> globalDefinesStore,
        ICiv4XmlStore<Civ4CivilizationInfos> civilizationInfosStore,
        ICiv4XmlStore<Civ4LeaderHeadInfos> civilizationLeaderHeadInfosStore,
        ICiv4XmlStore<Civ4TraitInfos> civilizationTraitInfosStore)
    {
        GameManager = gameManager;
        GlobalTypesStore = globalTypesStore;
        GlobalDefinesStore = globalDefinesStore;
        CivilizationInfosStore = civilizationInfosStore;
        CivilizationLeaderHeadInfosStore = civilizationLeaderHeadInfosStore;
        CivilizationTraitInfosStore = civilizationTraitInfosStore;
    }

    [HttpGet("{gameVariant}/assets/global-types")]
    public IActionResult GetTypes(Civ4GameVariant gameVariant)
    {
        var assetPath = GameManager.GetGlobalTypesFilepath(gameVariant);
        var parsed = GlobalTypesStore.LoadAsync(assetPath).Result;
        return Ok(parsed);
    }

    [HttpGet("{gameVariant}/assets/global-defines")]
    public IActionResult GetGlobalDefines(Civ4GameVariant gameVariant)
    {
        var assetPath = GameManager.GetGlobalDefinesFilepath(gameVariant);
        var parsed = GlobalDefinesStore.LoadAsync(assetPath).Result;
        return Ok(parsed);
    }

    [HttpGet("{gameVariant}/assets/civilizations")]
    public IActionResult GetCivilizationInfoDefines(Civ4GameVariant gameVariant)
    {
        var assetPath = GameManager.GetCivilizationInfosFilepath(gameVariant);
        var parsed = CivilizationInfosStore.LoadAsync(assetPath).Result;
        return Ok(parsed);
    }

    [HttpGet("{gameVariant}/assets/civilizations/leaders")]
    public IActionResult GetCivilizationLeaderHeadInfos(Civ4GameVariant gameVariant)
    {
        var assetPath = GameManager.GetCivilizationLeaderHeadInfosFilepath(gameVariant);
        var parsed = CivilizationLeaderHeadInfosStore.LoadAsync(assetPath).Result;
        return Ok(parsed);
    }

    [HttpGet("{gameVariant}/assets/civilizations/traits")]
    public IActionResult GetCivilizationTraitHeadInfos(Civ4GameVariant gameVariant)
    {
        var assetPath = GameManager.GetCivilizationTraitInfosFilepath(gameVariant);
        var parsed = CivilizationTraitInfosStore.LoadAsync(assetPath).Result;
        return Ok(parsed);
    }
}
