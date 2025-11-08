using BepInEx;
using HarmonyLib;

namespace MyMod;

internal static class ModInfo
{
    internal const string Guid = "dk.elinplugins.utadditives";
    internal const string Name = "My Elin Mod";
    internal const string Version = "1.0";
}

[BepInPlugin(ModInfo.Guid, ModInfo.Name, ModInfo.Version)]
internal class MyElinMod : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo("My mod...loaded?!")
    }
}

    public void OnStartCore()
    {
        var dir = Path.GetDirectoryName((steamapp)/Elin/Package/Mod)UTAdditives);
        var excel = dir + "/SourceCard.xlsx";
        var sources = Core.Instance.sources;
        ModUtil.ImportExcel(excel, "Thing", sources.things);
    }