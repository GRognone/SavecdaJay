float r;
float aire;
float volume;
Console.WriteLine("Veuillez saisir le rayon de la sphère svp");
r = float.Parse(Console.ReadLine());
aire = (float)(4 * Math.PI * Math.Pow(r, 2));
volume = (float)(4 * Math.PI * Math.Pow(r, 3) / 3);
Console.WriteLine("L'aire de la sphere est de " + aire);
Console.WriteLine("Le volume de la sphère est de " + volume);