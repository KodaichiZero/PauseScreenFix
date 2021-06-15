using HarmonyLib;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PSF {
	[HarmonyPatch(typeof(FPSInputModule), "ProcessMousePress")]
	class FPSInputModulePatch {
		static bool Prefix(ref PointerInputModule.MouseButtonEventData data, ref FPSInputModule __instance) {
			PointerEventData buttonData = data.buttonData;
			GameObject gameObject = buttonData.pointerCurrentRaycast.gameObject;
			if(gameObject == null && __instance.lastGroup != null && __instance.lastGroup is IngameMenu) {
				return false;
			}
			return true;
		}
	}
}
