using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] private Light lightSource;

    public void TurnOn()
    {
        lightSource.enabled = true;
    }

    public void TurnOff()
    {
        lightSource.enabled = false;
    }

    public void SetColor(Color color)
    {
        lightSource.color = color;
    }

    public Color GetColor()
    {
        return lightSource.color;
    }
}
