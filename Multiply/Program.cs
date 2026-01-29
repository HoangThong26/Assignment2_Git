
﻿namespace Multiply
{
        public enum SIGN
        {
            PLUS,
            MINUS,
            MULTIPLY,
            DIVIDE
        }
        public class Program
        {
            private Double calculate(SIGN sign, Double arg1, Double arg2)
            {
                switch (sign)
                {
                    case SIGN.MULTIPLY:
                        return arg1 * arg2;
                    default:
                        break;
                }
                return 0d;
            }
        }

﻿double Calculate(double a, double b, char op)
{
    switch (op)
    {
        case '*':
            return a * b;
      
        default:
            throw new ArgumentException("Invalid operator");
    }
feature/CPL26/Anh/implement_multiply
}
