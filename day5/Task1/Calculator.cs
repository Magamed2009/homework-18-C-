public class Calculator
{
    public double FirstNumber;
    public double SecondNumber;
    public Calculator(double firstNumber,double secondNumber)
    {
        FirstNumber = firstNumber;
        SecondNumber = secondNumber;
    }
    public double Sum()
    {
        return FirstNumber + SecondNumber;
    }
    public double Subtract()
    {
        return FirstNumber - SecondNumber;
    }
    public double Multiplication()
    {
        return FirstNumber * SecondNumber;
    }
    public double Division()
    {
        return FirstNumber / SecondNumber;
    }
}