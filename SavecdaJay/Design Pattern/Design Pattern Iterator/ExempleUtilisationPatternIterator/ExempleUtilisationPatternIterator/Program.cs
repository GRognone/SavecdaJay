using BiblioClassFigure;
using System.ComponentModel;
namespace Exo_Fig1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Cercle c1 = new Cercle(5, 30, 30);
            Cercle c2 = new Cercle(6, 40, 40);
            Cercle c3 = new Cercle(7, 50, 50);
            Cercle c4 = new Cercle(8, 60, 60);
            Cercle c5 = new Cercle(9, 7, 70);

            //c1.SeDessiner();

            Rectangle r1 = new Rectangle(3, 1, 1, 1);
            Rectangle r2 = new Rectangle(4, 2, 5, 5);
            Rectangle r3 = new Rectangle(5, 3, 10, 10);
            Rectangle r4 = new Rectangle(6, 4, 15, 15);
            Rectangle r5 = new Rectangle(7, 5, 20, 20);
            
            //r1.SeDessiner();

            Figures f1 = new Figures(9, 9);
            Figures f2 = new Figures(10, 10);
            Figures f3 = new Figures(11, 11);
            Figures f4 = new Figures(12, 12);
            Figures f5 = new Figures(13, 13);
            Figures f6 = new Figures(14, 14);
            Figures f7 = new Figures(15, 15);
            Figures f8 = new Figures(16, 16);
            Figures f9 = new Figures(17, 17);

            f1.Add(c1);
            f2.Add(c2);
            f2.Add(c3);
            f3.Add(c4);
            f3.Add(c5);

            // f1.SeDessiner();
            f4.Add(r1);
            f5.Add(r2);
            f5.Add(r3);
            f6.Add(r4);
            f6.Add(r5);

            //f2.SeDessiner();

            f7.Add(f1);
            f7.Add(f4);
            f8.Add(f2);
            f8.Add(f5);
            f9.Add(f5);
            f9.Add(f6);

            //f7.SeDessiner();
            
            for (int j = 0; j < f7.Count; j++)
            {
               
                Console.WriteLine(f8[j].ToString());
            }

            IteratorDeFigure i = new IteratorDeFigure(f5);
            //Figure fa = i.Current;
            //while (i.MoveNext())
            //{
            //    Figure figure = i.Current;
            //}

            foreach (Figure f in f5)
            {
                string s = f.ToString();
            }
        }
    }
}
