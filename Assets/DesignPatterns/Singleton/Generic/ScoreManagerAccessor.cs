using UnityEngine;
using Singleton;

public class ScoreManagerAccessor : MonoBehaviour
{
    void Start()
    {
        ScoreManager.Instance.IncreaseScore(10);
        Debug.Log(ScoreManager.Instance.Score);
    }
}
