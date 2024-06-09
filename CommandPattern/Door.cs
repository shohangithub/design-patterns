
namespace CommandPattern;
internal class Door
{
    public async Task Open()
    {
       await Task.Run(() =>
        {
            Console.WriteLine(" => Door Opened !");
        });
    }

    public async Task Close()
    {
        await Task.Run(() =>
        {
            Console.WriteLine(" => Door Closed !");
        });
    }
}
