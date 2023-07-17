using BiblioClassFigure;
using Exo_FigV2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Cercle c1 = new Cercle(3, 5, 7);
        c1.Accept(new VisiteurDeFigurePourConsole());

        Rectangle r1 = new Rectangle(2, 8, 7, 6);
        r1.Accept(new VisiteurDeFigurePourConsole());

        Figures f1 = new Figures(10, 10);
        f1.Add(c1);
        f1.Add(r1);
        f1.Accept(new VisiteurDeFigurePourConsole());
    }
}