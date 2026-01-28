double Calculate(double a, double b, char op)
{
    switch (op)
    {
        case '+':
            return a + b;
        default:
            throw new ArgumentException("Invalid operator");
    }
}
