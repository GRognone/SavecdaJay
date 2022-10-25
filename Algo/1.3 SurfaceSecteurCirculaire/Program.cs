float r;
float a;
float surface;
Console.WriteLine("Veuillez saisir le rayon du secteur circulaire svp");
r=float.Parse(Console.ReadLine());
Console.WriteLine( "Veuillez saisir l'angle du secteur circulaire svp");
a=float.Parse(Console.ReadLine());
surface =(float)( Math.PI * Math.Pow(r, 2) * a/360);
Console.WriteLine("L'aire du secteur circulaire est de "+Math.Round(surface,2)+ " cm²");
