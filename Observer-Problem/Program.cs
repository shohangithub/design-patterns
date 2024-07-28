
using Observer_Problem;

Stock stock = new();

while (true)
{
    var kepress = Console.ReadKey().Key;

    if (kepress == ConsoleKey.D0
        || kepress == ConsoleKey.D1
        || kepress == ConsoleKey.D2
        || kepress == ConsoleKey.D3
        || kepress == ConsoleKey.D4
        || kepress == ConsoleKey.D5
        || kepress == ConsoleKey.D6
        || kepress == ConsoleKey.D7
        || kepress == ConsoleKey.D8
        || kepress == ConsoleKey.D9
        || kepress == ConsoleKey.Decimal
        )
    {
        stock.CurrentStock = (int)kepress;
    }

}