namespace Generics;

public class Generic<T>
{
    public required T Property;

    public TOutput? Converter<TInput, TOutput>(TInput from)
    {
        TOutput? output = default;
        //extra code here
        return output;
    }
}