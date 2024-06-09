namespace CommandPattern;

internal class RemoteController
{
    private ICommand openButtonCommand;

    public void RegisterCommand(ICommand command)
    {
        this.openButtonCommand = command;
    }


    public async Task ButtonPressed()
    {
        await openButtonCommand.Execute();
    }

}
