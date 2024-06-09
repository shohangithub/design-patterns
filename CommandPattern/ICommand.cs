namespace CommandPattern;
internal interface ICommand
{
    // All we need is one method called execute().
    Task Execute();
}
