using CommandDesignPattern;
using UnityEngine;

public class FlashLightSetColorCommand : ICommand
{
    private FlashLight flashLight;
    private Color newColor;
    private Color previousColor;

    public FlashLightSetColorCommand(FlashLight flashLight, Color newColor): base()
    {
        this.flashLight = flashLight;
        this.newColor = newColor;
    }

    public void Execute()
    {
        previousColor = flashLight.GetColor();
        flashLight.SetColor(newColor);
    }

    public void Undo()
    {
        flashLight.SetColor(previousColor);
    }
}
