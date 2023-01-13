using ClassLibrary1Fraction;

namespace ConsoleApp1TestProgrammeFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();

            Fraction f1 = new Fraction(12, 7);
            Console.WriteLine(f1.ToString());

            Fraction f2 = new Fraction(9);
            Console.WriteLine(f2.ToString());

            Fraction f3 = new Fraction();
            Console.WriteLine(f3.ToString());

            Fraction f4 = new Fraction(4,7);
            f4.Oppose();
            Console.WriteLine(f4.ToString());

            Fraction f5 = new Fraction(4,7);
            f5.Inverse();
            Console.WriteLine(f5.ToString());
        }
    }
}