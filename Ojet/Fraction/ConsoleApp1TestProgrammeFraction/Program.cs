using ClassLibrary1Fraction;

namespace ConsoleApp1TestProgrammeFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();

            /* Fraction f1 = new Fraction(12, 7);
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

             Fraction f6 = new Fraction(11,7);
             Console.WriteLine(f6.ToString());
             Fraction f7 = new Fraction(5,4);
             Console.WriteLine(f7.ToString());
             bool estSuperieur = f6.SuperieurA(f7);

             Fraction f8 = new Fraction(11,7);
             Console.WriteLine(f8.ToString());
             Fraction f9 = new Fraction(22,14);
             Console.WriteLine(f9.ToString());
             bool estEgal = f8.EgalA(f9);
            
            Fraction f10 = new Fraction(120, -150);
            Console.WriteLine(f10.ToDisplay()); */

            Fraction f11 = new Fraction(5, 2);
            Fraction f12 = new Fraction(3, 4);

            //Fraction addition = f11.Plus (f12); //addition
            Fraction addition = f11 + f12; //addition surcharge operateur
            Console.WriteLine(addition.ToDisplay());


            //Fraction soustraction = f11.Moins(f12); // soustraction
            Fraction soustraction = f11 - f12; // soustraction surcharge operateur
            Console.WriteLine(soustraction.ToDisplay());

            //Fraction multiplication = f11.Multiplie(f12); // multipmlication
            Fraction multiplication = f11 * f12;// multiplication surcharge operateur
            Console.WriteLine(multiplication.ToDisplay());

            //Fraction division = f11.Divise(f12); // division
            Fraction division = f11 / f12; // division surcharge operateur
            Console.WriteLine(division.ToDisplay());

            Fraction frac = new(0,5);
            frac.Inverse();
            frac.Evalue();
        }
    }
}