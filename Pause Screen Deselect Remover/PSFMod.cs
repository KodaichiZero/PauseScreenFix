// Include this namespace to simplify the code below
using HarmonyLib;
using QModManager.API.ModLoading;

namespace PSF {
    // Your main patching class must have the QModCore attribute (and must be public)
    [QModCore]
    public static class PSFMod {
        // Your patching method must have the QModPatch attribute (and must be public)
        [QModPatch]
        public static void PSFInit() {
            // Add your patching code here
            Harmony harmony = new Harmony("PauseScreenFix");
            harmony.PatchAll();
        }
    }
}