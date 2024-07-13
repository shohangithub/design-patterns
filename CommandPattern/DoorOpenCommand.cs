namespace CommandPattern;

//This is a command, so we need to implement the ICommand interface.
internal class DoorOpenCommand(Door _door) : ICommand
{
    private DoorState prevState;
    public async Task Execute()
    {
        prevState = _door.GetCurrentState;
        //Console.WriteLine("\nPrevious State => " + prevState);
        await _door.Open();
    }

    public async Task Undo()
    {
        //Console.WriteLine("UNDO : Previous State => " + prevState);
        if (prevState == DoorState.CLOSE)
            await _door.Close();
    }
}
