using static CalculatorService.SIGN;

<<<<<<< Updated upstream
namespace CalculatorService
{


=======

namespace CalculatorService
{

>>>>>>> Stashed changes
    public class CalculatorService
    {
        private Double calculate(SIGN sign, Double arg1, Double arg2)
        {
            switch (sign)
            {
                case MINUS:
<<<<<<< Updated upstream
                    return arg1 - arg2;
=======
                    return arg1 / arg2;
>>>>>>> Stashed changes
                default:
                    break;
            }
            return 0d;
        }

    }
}