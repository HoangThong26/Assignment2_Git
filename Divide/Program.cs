using static Divide.SIGN;

namespace Divide
{
    internal class Program
    {
        private double calculate(SIGN sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case MULTIPLY:
                    if (arg2 == 0) throw new DivideByZeroException();
                    return arg1 / arg2;
                default:
                    break;
            }
            return 0d;
        }
    }
}
