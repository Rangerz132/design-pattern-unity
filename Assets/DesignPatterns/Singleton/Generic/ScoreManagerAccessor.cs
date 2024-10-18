using UnityEngine;
using SingletonDesignPattern;

public class ScoreManagerAccessor : MonoBehaviour
{
    void Start()
    {
        ScoreManager.Instance.IncreaseScore(10);
        Debug.Log(ScoreManager.Instance.Score);
    }
}
