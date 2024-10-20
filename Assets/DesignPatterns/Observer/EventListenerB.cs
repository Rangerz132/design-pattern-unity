using ObserverDesignPattern;
using UnityEngine;

public class EventListenerB : MonoBehaviour
{
    private void OnEnable()
    {
        EventTriggerManager.OnSpaceKeyPressed += DoStuff;
        EventTriggerManager.OnAlpha1KeyPressed += DoStuff2;
    }

    private void OnDisable()
    {
        EventTriggerManager.OnSpaceKeyPressed -= DoStuff;
        EventTriggerManager.OnAlpha1KeyPressed -= DoStuff2;
    }

    private void DoStuff()
    {
        Debug.Log("EventListenerB DoStuff");
    }

    private void DoStuff2(object sender, Alpha1KeyPressedEventArgs e)
    {
        Debug.Log("EventListenerB DoStuff2: " + e.Message + " " + e.Amount);
    }
}
