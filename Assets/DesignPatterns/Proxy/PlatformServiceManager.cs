using System;
using UnityEngine;

namespace ProxyDesignPattern
{
    public class PlatformServiceManager : MonoBehaviour, IPlatformService
    {
        public IPlatformService PlatformService { get; private set; }

        void Start()
        {
            PlatformService = new PlatformServiceA();
            //platformService = new PlatformServiceB();

            Init();
        }

        public object GetUser()
        {
            return PlatformService.GetUser();
        }

        public void Init()
        {
            PlatformService.Init();
        }

        public void Install()
        {
            PlatformService.Install();
        }

        public void ShowAd(AdType adType, Action onAdStarted, Action onAdFinished)
        {
            PlatformService.ShowAd(adType, onAdStarted, onAdFinished);
        }
    }
}
