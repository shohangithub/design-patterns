
namespace CommandPatternPractice.Receiver;

internal class Video
{

    string content=string.Empty;
    public void AddLabel()
    {
        content = $"<label>{content}</label>";
    }

    public void AddContrast()
    {
        content = $"<contrast>{content}</contrast>";
    }

    public string GetContent()
    {
        return content ;
    }

    public void SetContent(string content)
    {
        this.content = content ;
    }
}
