namespace MathLib.Sample;

internal class Program
{
    static void Main(string[] args)
    {
        var n1 = 17640;
        var n2 = 411600;

        var gcd = MathLib.GCD(n1, n2);
        var lcm = MathLib.LCM(n1, n2);

        Console.WriteLine($"LCM({n1}, {n2}) = {lcm}");
        Console.WriteLine($"GCD({n1}, {n2}) = {gcd}");

    }
}
