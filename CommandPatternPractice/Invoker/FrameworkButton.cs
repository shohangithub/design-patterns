using CommandPatternPractice.Commad;

namespace CommandPatternPractice.Invoker;


internal class FrameworkButton(ICommand _command)
{
    public void Click()
    {
        _command.Execute();
    }
}
