using ObserverDesignPattern;
using UnityEngine;

public class EventListenerA : MonoBehaviour
{
    private void OnEnable()
    {
        EventTriggerManager.OnSpaceKeyPressed += DoStuff;
        EventTriggerManager.OnAlpha1KeyPressed += DoStuff2;
        EventTriggerManager.OnAlpha2KeyPressed += GetMessage;
    }

    private void OnDisable()
    {
        EventTriggerManager.OnSpaceKeyPressed -= DoStuff;
        EventTriggerManager.OnAlpha1KeyPressed -= DoStuff2;
        EventTriggerManager.OnAlpha2KeyPressed += GetMessage;
    }

    private void DoStuff()
    {
        Debug.Log("EventListenerA DoStuff");
    }

    private void DoStuff2(object sender, Alpha1KeyPressedEventArgs e)
    {
        Debug.Log("EventListenerA DoStuff2: " + e.Message + " " + e.Amount);
    }

    private string GetMessage()
    {
        return "OnAlpha2KeyPressed ";
    }
}
