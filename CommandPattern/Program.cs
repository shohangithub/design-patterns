using CommandPattern;

RemoteController remote = new(); //The remote is our Invoker; it will be passed a command object that can be used to make requests.
Door door = new(); // Light object, this will be the Receiver of the request


Console.WriteLine("\nHey there, Please press O to open the door");
bool isOpened = false;
while (!isOpened)
{
    if (Console.ReadKey().Key == ConsoleKey.O)
    {
        DoorOpenCommand openCommand = new(door); // Here, create a command and pass the Receiver to it.

        remote.RegisterCommand(openCommand); // Here, pass the command to the Invoker.
        
        await remote.ButtonPressed(); //And then we simulate the button being pressed.
        
        isOpened = !isOpened;
    }
    else
    {
        Console.WriteLine(" => Invalid Command !\n");
    }
}

if (isOpened)
{
    Console.WriteLine("\nHey there, Please press C to close the door");
    while (isOpened)
    {
        if (Console.ReadKey().Key == ConsoleKey.C)
        {
            DoorCloseCommand closeCommand = new(door);// Here, create a command and pass the Receiver to it.

            remote.RegisterCommand(closeCommand); // Here, pass the command to the Invoker.

            await remote.ButtonPressed(); //And then we simulate the button being pressed.

            isOpened = !isOpened;
        }
        else
        {
            Console.WriteLine(" => Invalid Command !\n");
        }
    }
}

Console.ReadKey();

