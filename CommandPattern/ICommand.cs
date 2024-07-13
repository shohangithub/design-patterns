namespace CommandPattern;

//COMMAND
internal interface ICommand
{
    // All we need is one method called execute().
    Task Execute();
    Task Undo();
}
