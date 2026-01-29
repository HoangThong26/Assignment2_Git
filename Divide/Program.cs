namespace Divide
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
                    case SIGN.DIVIDE:
                    if (arg2 == 0) throw new DivideByZeroException();
                        return arg1/ arg2;
                    default:
                        break;
                }
                return 0d;
            }
        }
    }
