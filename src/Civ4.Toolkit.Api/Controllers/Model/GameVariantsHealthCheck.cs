using Civ4.Toolkit.Model;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Civ4.Toolkit.Api.Controllers.Model;

public class GameVariantsHealthCheck
{
    public HealthStatus Status
    {
        get
        {
            var configuredCount = VariantsHealth.Count(v => v.IsConfigured);
            var totalCount = VariantsHealth.Length;

            return configuredCount == totalCount ? HealthStatus.Healthy : HealthStatus.Unhealthy;
        }
    }

    public GameVariantHealthState[] VariantsHealth { get; set; } = Array.Empty<GameVariantHealthState>();
}

public class GameVariantHealthState
{
    public Civ4GameVariant GameVariant { get; set; } = Civ4GameVariant.Vanilla;
    public bool IsConfigured { get; set; } = false;
}