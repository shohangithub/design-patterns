namespace CommandPatternPractice.Commad;

internal interface IUndoCommand : ICommand
{
    void UnExecute();
}
