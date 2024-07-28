namespace Proxy_Problem;

internal class Ebook
{
    private string _fileName;

    public Ebook(string fileName)
    {
        _fileName = fileName;
        Load();
    }

    private void Load()
    {
        Console.WriteLine("Loading the ebook " + _fileName);
    }

    public void Show()
    {
        Console.WriteLine("Showing the ebook " + _fileName);
    }

    public string GetFileName() => _fileName;
}
