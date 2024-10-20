using System;
using UnityEngine;

namespace ObserverDesignPattern
{
    public class EventTriggerManager : MonoBehaviour
    {
        public static Action OnSpaceKeyPressed; // Action Example

        public static event EventHandler<Alpha1KeyPressedEventArgs> OnAlpha1KeyPressed; // EventHandler Example

        public static Func<string> OnAlpha2KeyPressed; // Func Example

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnSpaceKeyPressed?.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                var args = new Alpha1KeyPressedEventArgs("A", 1);
                OnAlpha1KeyPressed?.Invoke(this, args);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                string message = OnAlpha2KeyPressed?.Invoke();
                if (message != null)
                {
                    Debug.Log($"Event Triggered: {message}");
                }
            }
        }
    }

    public class Alpha1KeyPressedEventArgs : EventArgs
    {
        public string Message { get; set; }
        public int Amount { get; set; }

        public Alpha1KeyPressedEventArgs(string message, int amount)
        {
            Message = message;
            Amount = amount;
        }
    }
}

