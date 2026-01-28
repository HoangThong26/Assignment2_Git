using System;
using static Plus.SIGN;

namespace Plus
{
    internal class Program
    {
        private double calculate(SIGN sign, double arg1, double arg2)
        {
            switch (sign)
            {
                case PLUS:
                    return arg1 + arg2;
                default:
                    break;
            }
            return 0d;
        }

    }
}
