
using CommandPatternPractice.Commad;

namespace CommandPatternPractice;

internal class History
{
    private Stack<IUndoCommand> commands = new();

    public void Push(IUndoCommand command)
    {
        commands.Push(command);
    }

    public IUndoCommand Pop() => commands.Pop();

    public int Size() => commands.Count;
}
