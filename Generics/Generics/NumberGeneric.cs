using System.Numerics;

namespace Generics;

public class NumberGeneric<TNumber> where TNumber : INumber<TNumber>
{
    public TNumber SumOfTwoNumbers(TNumber firstNumber, TNumber secondNumber )
    {
        return firstNumber + secondNumber;
    }
}