
using System.ComponentModel;

namespace CommandPattern;

//INVOKER
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

    public DoorState GetCurrentState => this._state;
}



[DefaultValue(DoorState.CLOSE)]
internal enum DoorState
{
    CLOSE,
    OPEN
}