// See https://aka.ms/new-console-template for more information
using MainApp.PatternDemo;
using Pattern.Structural.Adapter;

Console.WriteLine("Hello, World!");

Console.WriteLine("--------------------------------------- Creational Pattern Start ---------------------------------------");
# region Creational Pattern
Console.WriteLine("=== Factory Pattern Demo Start ===");
IPatternDemo factoryDemo = new FactoryPatternDemo();
await factoryDemo.RunAsync();
Console.WriteLine("=== Factory Pattern Demo End ===");


#endregion



Console.WriteLine("--------------------------------------- Structural Pattern Start ---------------------------------------");
#region Structural Pattern

IPatternDemo adapterDemo = new AdapterPatternDemo();
await adapterDemo.RunAsync();

Console.WriteLine("--------------------------------------- Structural Pattern End ---------------------------------------");
#endregion

Console.WriteLine("--------------------------------------- Behavioral Pattern Start ---------------------------------------");
#region Behavioral Pattern

Console.WriteLine("=== Strategy Pattern Demo Start ===");
IPatternDemo strategyDemo = new StrategyPatternDemo();
await strategyDemo.RunAsync();
Console.WriteLine("=== Strategy Pattern Demo End ===");
#endregion
Console.WriteLine("--------------------------------------- Behavioral Pattern End ---------------------------------------");

