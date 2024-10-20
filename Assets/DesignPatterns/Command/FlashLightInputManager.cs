using System.Collections.Generic;
using UnityEngine;
using CommandDesignPattern;
using System.Collections;

public class FlashLightInputManager : MonoBehaviour
{
    public FlashLight flashLight;
    private Stack<ICommand> commandHistory = new Stack<ICommand>();
    private ICommand turnOnCommand;
    private ICommand turnOffCommand;
    private ICommand setColorRedCommand;
    private ICommand setColorGreenCommand;

    private void Start()
    {
        turnOnCommand = new FlashLightTurnOnCommand(flashLight);
        turnOffCommand = new FlashLightTurnOffCommand(flashLight);
        setColorRedCommand = new FlashLightSetColorCommand(flashLight, Color.red);
        setColorGreenCommand = new FlashLightSetColorCommand(flashLight, Color.green);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ExecuteCommand(turnOnCommand);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ExecuteCommand(turnOffCommand);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ExecuteCommand(setColorRedCommand);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ExecuteCommand(setColorGreenCommand);
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            UndoLastCommand();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ExecuteCommandsWithDelay(commandHistory, 2f));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(ExecuteCommandsInReverseWithDelay(commandHistory, 2f));
        }
    }

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        commandHistory.Push(command);
    }

    public void UndoLastCommand()
    {
        if (commandHistory.Count <= 0)
        {
            return;
        }

        ICommand lastCommand = commandHistory.Pop();
        lastCommand.Undo();
    }

    public void clearCommands()
    {
        if (commandHistory.Count <= 0)
        {
            return;
        }

        commandHistory.Clear();
    }

    private IEnumerator ExecuteCommandsWithDelay(Stack<ICommand> commandSequence, float delay)
    { 
        foreach (ICommand command in commandSequence)
        {
            command.Execute();
            yield return new WaitForSeconds(delay);
        }
    }

    private IEnumerator ExecuteCommandsInReverseWithDelay(Stack<ICommand> commandSequence, float delay)
    {
        List<ICommand> commands = new List<ICommand>();

        foreach (ICommand command in commandSequence)
        {
            commands.Add(command);
        }

        for (var i = commands.Count - 1; i >= 0; i--) {
            commands[i].Execute();
            yield return new WaitForSeconds(delay);
        }
    }
}