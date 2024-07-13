using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

RemoteController remote = new(); //The remote is our Invoker; it will be passed a command object that can be used to make requests.
Door door = new(); // Light object, this will be the Receiver of the request


Console.WriteLine("\nHey there, Please press O to open the door,\npress C to close the door or U for Undo\n");
bool isOpened = false;
while (true)
{
    var kepress = Console.ReadKey().Key;
    if (kepress == ConsoleKey.O && !isOpened)
    {
       
        
        
        DoorOpenCommand openCommand = new(door); // Here, create a command and pass the Receiver to it.
        remote.RegisterCommand(openCommand); // Here, pass the command to the Invoker.
        await remote.ButtonPressed(); //And then we simulate the button being pressed.








        isOpened = true; // It's not a related to command pattern
    }
    else if (kepress == ConsoleKey.C && isOpened)
    {
        
        
       
        DoorCloseCommand closeCommand = new(door);// Here, create a command and pass the Receiver to it.
        remote.RegisterCommand(closeCommand); // Here, pass the command to the Invoker.
        await remote.ButtonPressed(); //And then we simulate the button being pressed.






        isOpened = false; // It's not a related to command pattern
    }
    else if (kepress == ConsoleKey.U)
    {
        await remote.UndoButtonPressed(); //And then we simulate the button being pressed.
      
        
        
        isOpened = !isOpened; // It's not a related to command pattern
    }
    else if (kepress == ConsoleKey.Q)
    {
        break;
    }
    else
    {
        Console.WriteLine(" => Invalid Command !\n");
    }
}







//ICommand undoCommand;
//if (isOpened)
//{
//    Console.WriteLine("\nHey there, Please press C to close the door or U for Undo");
//    while (isOpened)
//    {
//        if (Console.ReadKey().Key == ConsoleKey.C)
//        {
//            DoorCloseCommand closeCommand = new(door);// Here, create a command and pass the Receiver to it.

//            remote.RegisterCommand(closeCommand); // Here, pass the command to the Invoker.

//            await remote.ButtonPressed(); //And then we simulate the button being pressed.
//            undoCommand = closeCommand;
//            isOpened = !isOpened;
//        }
//        else if (Console.ReadKey().Key == ConsoleKey.U)
//        {
//            await remote.UndoButtonPressed(); //And then we simulate the button being pressed.
//            isOpened = !isOpened;
//        }
//        else
//        {
//            Console.WriteLine(" => Invalid Command !\n");
//        }
//    }
//}

//Console.ReadKey();

