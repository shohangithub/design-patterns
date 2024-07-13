using CommandPattern.Command;

namespace CommandPattern.Invoker;

// INVOKER
// INVOKER
// INVOKER
internal class RemoteController
{
    private ICommand buttonCommand;

    public void RegisterCommand(ICommand command)
    {
        buttonCommand = command;
    }


    public async Task ButtonPressed()
    {
        await buttonCommand.Execute();
    }

    public async Task UndoButtonPressed()
    {
        await buttonCommand.Undo();
    }

}
