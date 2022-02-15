using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace ScrybeTribes
{

    //[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
	{
		private const string PluginGuid = "alabastor.inscryption.ScrybeTribes";

		private const string PluginName = "ScrybeTribes";

		private const string PluginVersion = "1.0.0.0";

		internal static ManualLogSource Log;

		private void Awake()
        {
            // Plugin startup logic
           // Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            Log = Logger;

            TribeAPI.NewTribe newTribe = new TribeAPI.NewTribe(null, true, null);
        }

		private void Start()
		{
			Log.LogDebug($"APIPlugin Start() begin");
			Log.LogDebug($"APIPlugin Start() end");
		}
	}
}
