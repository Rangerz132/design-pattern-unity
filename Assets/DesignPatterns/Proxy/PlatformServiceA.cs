using System;

namespace ProxyDesignPattern
{
    public class PlatformServiceA : IPlatformService
    {
        public object GetUser()
        {
            // Implement logic

            return null;
        }

        public void Init()
        {
            // Implement logic
        }

        public void Install()
        {
            // Implement logic
        }

        public void ShowAd(AdType adType, Action onAdStarted, Action onAdFinished)
        {
            switch (adType)
            {
                case AdType.MidGameAd:
                    ShowMidGameAd(onAdStarted, onAdFinished);
                    break;
                case AdType.RewardedAd:
                    ShowRewardedGameAd(onAdStarted, onAdFinished);
                    break;
            }
        }

        private void ShowMidGameAd(Action onAdStarted, Action onAdFinished)
        {
            onAdStarted?.Invoke();
            onAdFinished?.Invoke();
        }

        private void ShowRewardedGameAd(Action onAdStarted, Action onAdFinished)
        {
            onAdStarted?.Invoke();
            onAdFinished?.Invoke();
        }
    }
}
