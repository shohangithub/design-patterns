
using CommandPatternPractice.Commad;

namespace CommandPatternPractice.ConcreteCommand;

internal class UndoCommand(History _history) : ICommand
{
    public void Execute()
    {
        if (_history.Size() > 0)
            _history.Pop().UnExecute();
    }
}
