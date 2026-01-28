using static Minus.SIGN;

namespace Minus
{
    internal class Program
    {
        private double calculate(SIGN sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case MINUS:
                    return arg1 - arg2;
                default:
                    break;
            }
            return 0d;
        }
    }
}
