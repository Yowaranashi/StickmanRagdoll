#if UNITY_ANDROID
using UnityEngine;

namespace AndroidBridge
{
    //Yfgbc
    public class Bridge : MonoBehaviour
    {
        // --- Singleton ---
        private static Bridge _instance;
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

        // --- ����������� ������ �� ������ ---
        public static AdvertisementModule Advertisement => instance._advertisement;
        public static StorageModule Storage => instance._storage;
        public static PlatformModule Platform => instance._platform;
        public static SocialModule Social => instance._social;
        public static PlayerModule Player => instance._player;
        // (�������� ��� ���������, ���� �����)

        // --- ���� ��� ������� ---
        private AdvertisementModule _advertisement;
        private StorageModule _storage;
        private PlatformModule _platform;
        private SocialModule _social;
        private PlayerModule _player;

        private void Awake()
        {
            // ���� ���-�� ��� ������ Bridge � ���������� ��������
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            _instance = this;
            DontDestroyOnLoad(gameObject);

            // �������������� ������
            _advertisement = new AdvertisementModule();
            _storage = new StorageModule();
            _platform = new PlatformModule();
            _social = new SocialModule();
            _player = new PlayerModule();

            // ���� �����-�� ������ ������� ����������:
            // gameObject.AddComponent<LeaderboardModule>();
        }
    }

    // ������ ����������
    public class AdvertisementModule
        {
            public void ShowInterstitial() { Debug.Log("Ads not supported on Android stub"); }
            public void ShowRewarded() { Debug.Log("Ads not supported on Android stub"); }
            // � ��������� ������, ������� �� ���������
        }
        public class StorageModule
        {
            public bool IsSupported() => false;
            public string GetData(string k) => null;
            public void SetData(string k, string v) { }
            // �
        }
        public class PlatformModule
        {
            public string GetPlatformId() => SystemInfo.deviceUniqueIdentifier;
            public string GetPlatformLanguage() => Application.systemLanguage.ToString();
            // �
        }
        public class SocialModule
        {
            public bool IsShareSupported() => false;
            // �
        }
        public class PlayerModule
        {
            public bool IsAuthorized() => false;
            // �
        }
        // � �.?�. ��� ���� �������, ���������� � �������.
    }
#endif
