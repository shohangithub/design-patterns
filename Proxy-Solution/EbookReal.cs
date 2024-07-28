namespace Proxy_Solution;

internal class EbookReal : IEbook
{
    private string _fileName;

    public EbookReal(string fileName)
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
