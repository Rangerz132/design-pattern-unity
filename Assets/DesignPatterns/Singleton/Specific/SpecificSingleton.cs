using UnityEngine;

namespace SingletonDesignPattern
{
    public class SpecificSingleton : MonoBehaviour
    {
        public static SpecificSingleton Instance { get; private set; }

        public int Score { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {

                Destroy(gameObject);
            }
        }

        public void IncreaseScore(int value) {
            Score += value;
        }

        public void DecreaseScore(int value)
        {
            Score -= value;
        }
    }
}

