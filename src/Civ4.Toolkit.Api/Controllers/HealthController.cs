using Civ4.Toolkit.Api.Controllers.Model;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Services;
using Microsoft.AspNetCore.Mvc;

namespace Civ4.Toolkit.Api.Controllers;

[Route("health")]
[ApiController]
public class HealthController : ControllerBase
{
    public ICiv4GameManager GameManager { get; }

    public HealthController(ICiv4GameManager gameManager)
    {
        GameManager = gameManager;
    }
    
    [HttpGet]
    public ActionResult<GameVariantsHealthCheck> GetHealth()
    {
        var result = new GameVariantsHealthCheck
        {
            VariantsHealth = Enum.GetValues<Civ4GameVariant>().ToList().Select(gv =>
                new GameVariantHealthState
                {
                    GameVariant = gv,
                    IsConfigured = GameManager.IsConfigured(gv)
                }).ToArray()
        };

        return Ok(result);
    }
}
