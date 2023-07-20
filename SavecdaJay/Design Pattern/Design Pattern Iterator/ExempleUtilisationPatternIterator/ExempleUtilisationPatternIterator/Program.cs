using BiblioClassFigure;
using System.ComponentModel;
namespace Exo_Fig1
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");


                Cercle c1 = new Cercle(5, 2, 3);
                Cercle c2 = new Cercle(6, 7, 8);
                //c1.SeDessiner();

                Rectangle r1 = new Rectangle(3, 2, 4, 5);
                //r1.SeDessiner();

                Figures f1 = new Figures(9, 9);
                Figures f2 = new Figures(10, 10);
                Figures f3 = new Figures(9, 9);
                f1.Add(c1);
                f1.Add(c2);
                // f1.SeDessiner();
                f2.Add(r1);
                //f2.SeDessiner();

                f3.Add(f1);
                f3.Add(f2);
                f3.SeDessiner();

                for (int i = 0; i < f3.Count; i++)
                {
                    f3[i].SeDessiner(); // faire le ToString
                }

                IteratorDeFigure i = new IteratorDeFigure(f3);
                bool r = i.MoveNext();
                Figure f = i.Current;




            }
        }
    }
