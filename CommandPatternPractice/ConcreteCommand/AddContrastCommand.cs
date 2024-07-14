using CommandPatternPractice.Commad;
using CommandPatternPractice.Receiver;

namespace CommandPatternPractice.ConcreteCommand
{
    internal class AddContrastCommand(Video _video, History _history) : IUndoCommand
    {
        string previousContent;
        

        public void Execute()
        {
            previousContent = _video.GetContent();
            _video.AddContrast();
            _history.Push(this);
        }

        public void UnExecute()
        {
          _video.SetContent(previousContent);
        }
    }
}
