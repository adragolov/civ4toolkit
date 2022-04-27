using Civ4.Toolkit.Services.Default;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Civ4.Toolkit.Services;

public static class Civ4ServiceCollectionExtensions
{
    public static IServiceCollection AddCiv4Services(this IServiceCollection serviceCollection)
    {
        serviceCollection.TryAddSingleton<ICiv4GameManager, Civ4GameManager>();
        serviceCollection.TryAddTransient(typeof(ICiv4XmlStore<>), typeof(Civ4XmlStore<>));
        return serviceCollection;
    }
}
