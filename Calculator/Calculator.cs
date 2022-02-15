namespace Calculator;

public class Calculator
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    public int Add() => FirstNumber + SecondNumber;

    public int Sub()
    {
        if (FirstNumber > SecondNumber)
            return FirstNumber - SecondNumber;

        return -1;
    }
}