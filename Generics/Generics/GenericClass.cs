namespace Generics;

public class GenericClass<T>
{
    public required T Property;

    public TOutput? Converter<TInput, TOutput>(TInput from)
    {
        TOutput? output = default;
        //extra code here
        return output;
    }
}