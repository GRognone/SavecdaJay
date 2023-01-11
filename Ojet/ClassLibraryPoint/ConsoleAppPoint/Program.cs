using ClassLibraryPoint;

namespace ConsoleAppPoint
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Point point = new Point(2,5);

            Point point2 = point.SymetrieOrdonee();
            Console.WriteLine(point2.ToString());

            Point point3 = point.SymetrieAbcisse();
            Console.WriteLine(point3.ToString());
           
            Point point4 = point.SymetrieOrigine();
            Console.WriteLine(point4.ToString());

            Point point5 = point.Permuter();
            Console.WriteLine(point5.ToString());
        }
    }
}