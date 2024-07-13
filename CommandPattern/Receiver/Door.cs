
using System.ComponentModel;

namespace CommandPattern.Receiver;

//RECEIVER
//RECEIVER
//RECEIVER

internal class Door
{
    private DoorState _state = new();
    public async Task Open()
    {
        await Task.Run(() =>
         {
             Console.WriteLine(" => Door Opened !");
             _state = DoorState.OPEN;
         });
    }

    public async Task Close()
    {
        await Task.Run(() =>
        {
            Console.WriteLine(" => Door Closed !");
            _state = DoorState.CLOSE;
        });
    }

    public DoorState GetCurrentState => _state;
}



[DefaultValue(CLOSE)]
internal enum DoorState
{
    CLOSE,
    OPEN
}