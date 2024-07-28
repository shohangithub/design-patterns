namespace Proxy_Solution;

internal class Library
{
    private Dictionary<string, IEbook> _ebooks = new();

    public void Add(IEbook ebook)
    {
        _ebooks.Add(ebook.GetFileName(), ebook);
    }

    public void Open(string filename)
    {
        IEbook? ebook;
        bool result = _ebooks.TryGetValue(filename, out ebook);
        if (result)
            ebook?.Show();
    }
}
