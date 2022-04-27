using Civ4.Toolkit.Model;

namespace Civ4.Toolkit.Services;

public interface ICiv4GameManager
{
    bool IsConfigured(Civ4GameVariant variant);
    string GetGameRoot(Civ4GameVariant variant);
    void ConfigureGameRoot(Civ4GameVariant variant, string gameRoot);
    string GetAssetsDir(Civ4GameVariant variant);
    string GetAssetsXmlDir(Civ4GameVariant variant);
    string GetAssetXmlFilepath(Civ4GameVariant variant, string relativePath);
}
