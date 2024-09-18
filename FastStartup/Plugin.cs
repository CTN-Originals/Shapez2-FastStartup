using BepInEx;
using BepInEx.Logging;
using FastStartup.Utils;
using HarmonyLib;

namespace FastStartup;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin {
	internal static new ManualLogSource Logger;
	public static Harmony Harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

	public static bool DebugMode = false;
	
	private void Awake() {
		#if DEBUG
			DebugMode = true;
		#endif

		Logger = base.Logger;
		Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded! ({(DebugMode ? "Debug" : "Release")})");

		Harmony.PatchAll();
	}
}