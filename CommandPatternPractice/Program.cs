// See https://aka.ms/new-console-template for more information

//CLIENT
//CLIENT
//CLIENT

using CommandPatternPractice;
using CommandPatternPractice.ConcreteCommand;
using CommandPatternPractice.Invoker;
using CommandPatternPractice.Receiver;

Video video = new();
History history = new();
video.SetContent("Hi, I'm the video content.");



AddLabelCommand addLabelCommand = new(video, history);
AddContrastCommand addContrastCommand = new(video, history);
UndoCommand undoCommand = new UndoCommand(history);


Console.WriteLine("Before Apply:");
Console.WriteLine(video.GetContent());

FrameworkButton addLabelButton = new(addLabelCommand); //Button 1
addLabelButton.Click();



Console.WriteLine("After Applied");
Console.WriteLine(video.GetContent());

FrameworkButton addContrastButton = new(addContrastCommand); //Button 2
addContrastButton.Click();


Console.WriteLine("After Applied Contrast");
Console.WriteLine(video.GetContent());



FrameworkButton undoButton = new(undoCommand); //Button 3 
undoButton.Click();


Console.WriteLine("After Undo 1");
Console.WriteLine(video.GetContent());

undoButton.Click();

Console.WriteLine("After Undo 2");
Console.WriteLine(video.GetContent());


undoButton.Click();
undoButton.Click();
Console.WriteLine("After undo many times...");
Console.WriteLine(video.GetContent());
