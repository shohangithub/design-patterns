namespace Proxy_Solution;

internal class EbookProxy : IEbook
{
    private EbookReal ebook;
    private string _fileName;

    public EbookProxy(string fileName)
    {
        _fileName = fileName;
    }


    public string GetFileName()
    {
        return _fileName;
    }

    public void Show()
    {
        if (ebook == null)
            ebook = new EbookReal(_fileName);

        ebook.Show();
    }
}
