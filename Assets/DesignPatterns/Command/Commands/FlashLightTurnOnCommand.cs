using CommandDesignPattern;

public class FlashLightTurnOnCommand : ICommand
{
    private FlashLight flashLight;

    public FlashLightTurnOnCommand(FlashLight flashLight) {
        this.flashLight = flashLight;
    }

    public void Execute()
    {
        flashLight.TurnOn();
    }

    public void Undo()
    {
        flashLight.TurnOff();
    }
}
