// See https://aka.ms/new-console-template for more information
// https://learn.microsoft.com/en-us/dotnet/standard/generics/
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters

using BenchmarkDotNet.Running;
using Generics;


var stringGeneric = new GenericClass<string>
{
    Property = "T placeholder (type) is string"
};

var intGeneric = new GenericClass<int>
{
    Property = 10
};

var listGeneric = new GenericClass<List<string>>
{
    Property = new List<string>
    {
        "T placeholder (type) is list with objects of type string", 
        "T placeholder (type) is list with objects of type string",
    }
};

// BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(stringGeneric.GetType());
Console.WriteLine(stringGeneric.Property);
Console.WriteLine(intGeneric.GetType());
Console.WriteLine(intGeneric.Property);
Console.WriteLine(listGeneric.GetType());
listGeneric.Property.ForEach(Console.WriteLine);
