// See https://aka.ms/new-console-template for more information
using MainApp.PatternDemo;
using Pattern.Structural.Adapter;

Console.WriteLine("Hello, World!");

#region Structural Pattern

IPatternDemo adapterDemo = new AdapterPatternDemo();
await adapterDemo.RunAsync();

#endregion
