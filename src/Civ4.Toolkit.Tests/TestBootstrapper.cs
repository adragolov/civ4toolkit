using System;
using Civ4.Toolkit.Model;
using Civ4.Toolkit.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NUnit.Framework;

namespace Civ4.Toolkit.Tests;

[SetUpFixture]
public class TestBootstrapper
{
    public static readonly string TestRunId = Guid.NewGuid().ToString();

    public static DateTimeOffset? TestRunStart;

    public static DateTimeOffset? TestRunFinish;
    
    public static ILogger<TestBootstrapper>? TestLogger { get; private set; }
    
    public static IHost? TestHost { get; private set; }
    
    public static IServiceScope? TestServiceScope { get; private set; }

    public static T ResolveDependency<T>() where T: notnull
    {
        return TestServiceScope!.ServiceProvider.GetRequiredService<T>();
    }
    
    public static ICiv4GameManager ResolveGameManager()
    {
        return ResolveDependency<ICiv4GameManager>();
    }
    
    public static ICiv4XmlValidator ResolveXmlValidator()
    {
        return ResolveDependency<ICiv4XmlValidator>();
    }

    public static ICiv4XmlStore<TXmlAssetFile> ResolveXmlStore<TXmlAssetFile>() where TXmlAssetFile : Civ4AssetFile
    {
        return ResolveDependency<ICiv4XmlStore<TXmlAssetFile>>();
    }

    [OneTimeSetUp]
    public void Setup()
    {
        TestRunStart = DateTimeOffset.Now;
        TestHost = Civ4Toolkit.CreateCiv4Host();
        TestServiceScope = TestHost.Services.CreateScope();
        TestLogger = ResolveDependency<ILogger<TestBootstrapper>>();

        Assert.NotNull(TestHost);
        Assert.NotNull(TestServiceScope);
        Assert.NotNull(TestLogger);
        
        TestLogger.LogInformation("Civ4Toolkit test run {TestRunId} started", TestRunId);
    }

    [OneTimeTearDown]
    public void Destroy()
    {
        TestRunFinish = DateTimeOffset.Now;
        TestLogger?.LogInformation("Civ4Toolkit test run {TestRunId} complete. Duration = {Duration}",
            TestRunId,
            TestRunFinish - TestRunStart);
        
        TestServiceScope?.Dispose();
        TestHost?.Dispose();
    }
}
