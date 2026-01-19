// See https://aka.ms/new-console-template for more information
using MainApp.PatternDemo;
using Pattern.Structural.Adapter;

Console.WriteLine("Hello, World!");

Console.WriteLine("--------------------------------------- Structural Pattern Start ---------------------------------------");
#region Structural Pattern

IPatternDemo adapterDemo = new AdapterPatternDemo();
await adapterDemo.RunAsync();

Console.WriteLine("--------------------------------------- Structural Pattern End ---------------------------------------");
#endregion

Console.WriteLine("--------------------------------------- Behavioral Pattern Start ---------------------------------------");
#region Behavioral Pattern

Console.WriteLine("=== Behavioral Pattern Demo ===");
IPatternDemo strategyDemo = new StrategyPatternDemo();
await strategyDemo.RunAsync();
Console.WriteLine("=== End of Behavioral Pattern Demo ===");
#endregion
Console.WriteLine("--------------------------------------- Behavioral Pattern End ---------------------------------------");

