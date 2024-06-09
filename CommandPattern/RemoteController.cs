namespace CommandPattern;

internal class RemoteController
{
    private ICommand buttonCommand;

    public void RegisterCommand(ICommand command)
    {
        this.buttonCommand = command;
    }


    public async Task ButtonPressed()
    {
        await buttonCommand.Execute();
    }

}
