using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand;

//CONCRETE COMMAND
//CONCRETE COMMAND
//CONCRETE COMMAND

//This is a command, so we need to implement the ICommand interface.
internal class DoorCloseCommand(Door _door) : ICommand
{
    private DoorState prevState;
    public async Task Execute()
    {
        prevState = _door.GetCurrentState;
        //Console.WriteLine("\nPrevious State => " + prevState);
        await _door.Close();
    }
    public async Task Undo()
    {
        if (prevState == DoorState.OPEN)
            await _door.Open();
    }
}
