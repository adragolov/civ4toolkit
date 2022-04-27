using Microsoft.Extensions.Hosting;
using Serilog;

namespace Civ4.Toolkit.Services;

public static class Civ4Toolkit
{
    public static IHost CreateCiv4Host()
    {
        var builder = new HostBuilder();

        builder
            .ConfigureServices((_, collection) =>
            {
                collection.AddCiv4Services();
            })
            .UseSerilog((_, _, loggerConfiguration) =>
            {
                loggerConfiguration
                    .MinimumLevel.Verbose()
                    .Enrich.FromLogContext()
                    .WriteTo.Console();
            });

        
        var result = builder.Build();
        return result;
    }
}
