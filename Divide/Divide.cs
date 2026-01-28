double Calculate(double a, double b, char op)
{
    switch (op)
    {
        case '/':
        if(b == 0)throw new DivideByZeroException();
            return a / b;
        default:
            throw new ArgumentException("Invalid operator");
    }
}
