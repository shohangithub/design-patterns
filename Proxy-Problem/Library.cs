namespace Proxy_Problem;

internal class Library
{

    private Dictionary<string, Ebook> _ebooks = new();
     
    public void Add(Ebook ebook)
    {
        _ebooks.Add(ebook.GetFileName(), ebook);
    }

    public void Open(string filename)
    {
        Ebook? ebook;
        bool result = _ebooks.TryGetValue(filename, out ebook);
        if (result)
            ebook?.Show();
    }
}
