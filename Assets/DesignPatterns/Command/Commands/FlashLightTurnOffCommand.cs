using CommandDesignPattern;

public class FlashLightTurnOffCommand : ICommand
{
    private FlashLight flashLight;

    public FlashLightTurnOffCommand(FlashLight flashLight)
    {
        this.flashLight = flashLight;
    }

    public void Execute()
    {
        flashLight.TurnOff();
    }

    public void Undo()
    {
        flashLight.TurnOn();
    }
}
