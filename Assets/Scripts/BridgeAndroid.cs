#if UNITY_ANDROID
using UnityEngine;

namespace AndroidBridge
{
    //Yfgbc
    public class Bridge : MonoBehaviour
    {
        // ¬с€ логика Singleton, если тебе нужна глобальна€ точка доступа:
        static Bridge _instance;
        public static Bridge instance
        {
            get
            {
                if (_instance == null)
                {
                    var go = new GameObject("Bridge");
                    _instance = go.AddComponent<Bridge>();
                    DontDestroyOnLoad(go);
                }
                return _instance;
            }
        }

        // ќпредел€ем свойства-модули, возвращающие Ђпустышкиї
        public static AdvertisementModule advertisement => instance._advertisement;
        public static StorageModule storage => instance._storage;
        public static PlatformModule platform => instance._platform;
        public static SocialModule social => instance._social;
        public static PlayerModule player => instance._player;
        // Еи т.?д. дл€ всех используемых модулей

        // «десь Ц реальные классы Ђмодулиї, которые ничего не делают
        AdvertisementModule _advertisement = new AdvertisementModule();
        StorageModule _storage = new StorageModule();
        PlatformModule _platform = new PlatformModule();
        SocialModule _social = new SocialModule();
        PlayerModule _player = new PlayerModule();
        // Е

        // ѕустые реализации
        public class AdvertisementModule
        {
            public void ShowInterstitial() { Debug.Log("Ads not supported on Android stub"); }
            public void ShowRewarded() { Debug.Log("Ads not supported on Android stub"); }
            // Е остальные методы, которые ты вызываешь
        }
        public class StorageModule
        {
            public bool IsSupported() => false;
            public string GetData(string k) => null;
            public void SetData(string k, string v) { }
            // Е
        }
        public class PlatformModule
        {
            public string GetPlatformId() => SystemInfo.deviceUniqueIdentifier;
            public string GetPlatformLanguage() => Application.systemLanguage.ToString();
            // Е
        }
        public class SocialModule
        {
            public bool IsShareSupported() => false;
            // Е
        }
        public class PlayerModule
        {
            public bool IsAuthorized() => false;
            // Е
        }
        // » т.?д. дл€ всех модулей, упом€нутых в ошибках.
    }
}
#endif
