using System;

namespace ProxyDesignPattern
{
    public enum AdType
    {
        MidGameAd,
        RewardedAd
    }

    public interface IPlatformService
    {
        void Init();
        void Install();
        object GetUser();
        void ShowAd(AdType adType, Action onAdStarted, Action onAdFinished);
    }
}

