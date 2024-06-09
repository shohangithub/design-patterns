namespace CommandPattern;

//This is a command, so we need to implement the ICommand interface.
internal class DoorCloseCommand(Door _door) : ICommand
{
    public async Task Execute()
    {
        await _door.Close();
    }
}
