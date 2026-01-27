using static CalculatorService.SIGN;


namespace CalculatorService
{

    public class CalculatorService
    {
        private Double calculate(SIGN sign, Double arg1, Double arg2)
        {
            switch (sign)
            {
                case DIVIDE:
                    if (arg2 == 0) throw new ArithmeticException("Divide by zero");
                    return arg1 / arg2;
                default:
                    break;
            }
            return 0d;
        }


    }
}