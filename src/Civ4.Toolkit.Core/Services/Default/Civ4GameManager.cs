using System;
using System.Collections.Generic;
using System.IO;
using Civ4.Toolkit.Model;
using Microsoft.Extensions.Logging;

namespace Civ4.Toolkit.Services.Default;

public class Civ4GameManager : ICiv4GameManager
{
    public ILogger<ICiv4GameManager> Logger { get; }

    private static class EnvironmentVars
    {
        public static readonly string GameRootVanilla = "CIV4_GAME_ROOT";
        public static readonly string GameRootWarlords = "CIV4_GAME_ROOT_WARLORDS";
        public static readonly string GameRootBeyondTheSword = "CIV4_GAME_ROOT_BTS";
    }

    private readonly Dictionary<Civ4GameVariant, string> GameDirectories = new();

    public Civ4GameManager(ILogger<ICiv4GameManager> logger)
    {
        Logger = logger;
        InitializeGameRoots();
    }

    public bool IsConfigured(Civ4GameVariant variant)
    {
        return GameDirectories.ContainsKey(variant);
    }

    public string GetGameRoot(Civ4GameVariant variant)
    {
        return GameDirectories[variant];
    }

    public void ConfigureGameRoot(Civ4GameVariant variant, string gameRoot)
    {
        gameRoot = gameRoot.StartsWith("~/") ?
            gameRoot.Replace("~", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) :
            gameRoot;
        
        if (!Directory.Exists(gameRoot))
        {
            throw new DirectoryNotFoundException(
                $"Directory '{gameRoot}' not found.");
        }
        
        GameDirectories[variant] = gameRoot;
    }

    public string GetAssetsDir(Civ4GameVariant variant)
    {
        return Path.Combine(GetGameRoot(variant), "Assets");
    }
    
    public string GetAssetsXmlDir(Civ4GameVariant variant)
    {
        return Path.Combine(GetAssetsDir(variant), "XML");
    }

    public string GetAssetXmlFilepath(Civ4GameVariant variant, string relativePath)
    {
        return Path.Combine(GetAssetsXmlDir(variant), relativePath);
    }

    private void InitializeGameRoots()
    {
        var vanillaDir = Environment.GetEnvironmentVariable(EnvironmentVars.GameRootVanilla);
        if (vanillaDir != null)
        {
            Logger.LogInformation(
                "Configuring from environment variable {EnvironmentVariable}. {GameVariant} = {RootDir}",
                EnvironmentVars.GameRootVanilla,
                Civ4GameVariant.Vanilla, vanillaDir);
            ConfigureGameRoot(Civ4GameVariant.Vanilla, vanillaDir);
        }
        else
        {
            Logger.LogWarning(
                "Configuration from {EnvironmentVariable} fails. The environment variable is not set.",
                EnvironmentVars.GameRootVanilla);
        }

        var warlordsDir = Environment.GetEnvironmentVariable(EnvironmentVars.GameRootWarlords);
        if (warlordsDir != null)
        {
            Logger.LogInformation(
                "Configuring from environment variable {EnvironmentVariable}. {GameVariant} = {RootDir}",
                EnvironmentVars.GameRootWarlords,
                Civ4GameVariant.Warlords, warlordsDir);
            ConfigureGameRoot(Civ4GameVariant.Warlords, warlordsDir);
        }
        else
        {
            Logger.LogWarning(
                "Configuration from {EnvironmentVariable} fails. The environment variable is not set.",
                EnvironmentVars.GameRootWarlords);
        }
        
        var btsDir = Environment.GetEnvironmentVariable(EnvironmentVars.GameRootBeyondTheSword);
        if (btsDir != null)
        {
            Logger.LogInformation(
                "Configuring from environment variable {EnvironmentVariable}. {GameVariant} = {RootDir}",
                EnvironmentVars.GameRootBeyondTheSword,
                Civ4GameVariant.BeyondTheSword, btsDir);
            ConfigureGameRoot(Civ4GameVariant.BeyondTheSword, btsDir);
        }
        else
        {
            Logger.LogWarning(
                "Configuration from {EnvironmentVariable} fails. The environment variable is not set.",
                EnvironmentVars.GameRootBeyondTheSword);
        }
    }
}
