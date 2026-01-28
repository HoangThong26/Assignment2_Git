
public class phepchia
{
    public double Divide(int a, int b)
    {
        if (b == 0) throw new Exception("Divide by zero");
        return (double)a / b;
    }

}