#if UNITY_ANDROID
using UnityEngine;

namespace AndroidBridge
{
    //Yfgbc
    public class Bridge : MonoBehaviour
    {
        // ��� ������ Singleton, ���� ���� ����� ���������� ����� �������:
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

        // ���������� ��������-������, ������������ ���������
        public static AdvertisementModule advertisement => instance._advertisement;
        public static StorageModule storage => instance._storage;
        public static PlatformModule platform => instance._platform;
        public static SocialModule social => instance._social;
        public static PlayerModule player => instance._player;
        // �� �.?�. ��� ���� ������������ �������

        // ����� � �������� ������ �������, ������� ������ �� ������
        AdvertisementModule _advertisement = new AdvertisementModule();
        StorageModule _storage = new StorageModule();
        PlatformModule _platform = new PlatformModule();
        SocialModule _social = new SocialModule();
        PlayerModule _player = new PlayerModule();
        // �

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
}
#endif
