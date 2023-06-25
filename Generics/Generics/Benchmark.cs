using System.Collections;
using System.Text.Json;

namespace Generics;
using BenchmarkDotNet.Attributes;

public class Benchmark
{
    
    [Params(1000, 10000)]
    public int Count;

    [Benchmark]
    public string ArrayListAdd()
    {
        var arrayList = new ArrayList();
        for (var i = 0; i < Count; i++)
        {
            arrayList.Add(new GenericClass<string>
            {
                Property = "Generic class string"
            });
        }

        return JsonSerializer.Serialize(arrayList);
    }

    [Benchmark]
    public string ListAdd()
    {
        var list = new List<GenericClass<string>>();
        for (var i = 0; i < Count; i++)
        {
            list.Add(new GenericClass<string>
            {
                Property = "Generic class string"
            });
        }

        return JsonSerializer.Serialize(list);
    }

}