namespace MathLib;

public class MathLib
{
    public static long GCD(long a, long b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static long LCM(long a, long b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
}
