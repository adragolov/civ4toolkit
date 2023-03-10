using Civ4.Toolkit.Model;

namespace Civ4.Toolkit.Services;

public interface ICiv4GameManager
{
    Civ4GameVariant[] GetConfiguredGameVariants();
    bool IsConfigured(Civ4GameVariant variant);
    string GetGameRoot(Civ4GameVariant variant);
    void ConfigureGameRoot(Civ4GameVariant variant, string gameRoot);
    string GetAssetsDir(Civ4GameVariant variant);
    string GetAssetsXmlDir(Civ4GameVariant variant);
    string GetAssetXmlFilepath(Civ4GameVariant variant, string relativePath);
    
    string GetGlobalTypesFilepath(Civ4GameVariant variant);
    string GetGlobalDefinesFilepath(Civ4GameVariant variant);
    string GetCivilizationInfosFilepath(Civ4GameVariant variant);
    string GetCivilizationLeaderHeadInfosFilepath(Civ4GameVariant variant);
    string GetCivilizationTraitInfosFilepath(Civ4GameVariant variant);
}
