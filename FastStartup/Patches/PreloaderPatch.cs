using HarmonyLib;
using FastStartup.Utils;

namespace FastStartup.Patches;

[HarmonyPatch(typeof(Preloader))]
public static class PreloaderPatch {
	[HarmonyPatch("Start"), HarmonyPrefix]
	public static void StartPatch(ref Preloader __instance) {
		CLogger.LogDebug($"Preloader.Start");
		__instance.StateIndex += 1;
	}
}