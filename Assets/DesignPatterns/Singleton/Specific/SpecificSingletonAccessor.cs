using UnityEngine;
using SingletonDesignPattern;

public class SpecificSingletonAccessor : MonoBehaviour
{
    void Start()
    {
        SpecificSingleton.Instance.IncreaseScore(20);
        Debug.Log(SpecificSingleton.Instance.Score);
    }
}


