namespace Observer_Problem;

internal class StatusBar
{
    public void Display(int stock)
    {
        Console.WriteLine("Statusbar updated");
        Console.WriteLine("Current Stock:" + stock);
    }
}