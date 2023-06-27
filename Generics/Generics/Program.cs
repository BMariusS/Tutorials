// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Generics;


var stringGeneric = new Generic<string>
{
    Property = "T placeholder (type) is string"
};

var intGeneric = new Generic<int>
{
    Property = 10
};

var listGeneric = new Generic<List<string>>
{
    Property = new List<string>
    {
        "T placeholder (type) is list with objects of type string", 
        "T placeholder (type) is list with objects of type string",
        // Wrong assignment to demonstrate that you can't use int
        // 10
    }
};

var intNumberGeneric = new NumberGeneric<int>();
var floatNumberGeneric = new NumberGeneric<float>();


BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(stringGeneric.GetType());
Console.WriteLine(stringGeneric.Property);
Console.WriteLine(intGeneric.GetType());
Console.WriteLine(intGeneric.Property);
Console.WriteLine(listGeneric.GetType());
listGeneric.Property.ForEach(Console.WriteLine);

Console.WriteLine(intNumberGeneric.SumOfTwoNumbers(10,20));
// Wrong assignment to demonstrate that you can't use float to int generic type parameter
// Console.WriteLine(intNumberGeneric.SumOfTwoNumbers(10f,20f));
Console.WriteLine(floatNumberGeneric.SumOfTwoNumbers(10f,70f));
// Wrong assignment to demonstrate that you can't use double to float generic type parameter
// Console.WriteLine(floatNumberGeneric.SumOfTwoNumbers(10d,20d));





