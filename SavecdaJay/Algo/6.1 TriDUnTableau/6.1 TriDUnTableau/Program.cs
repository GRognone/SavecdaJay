/*
 * Soit T un tableau de nombres entiers non trié.
Trier le tableau et afficher tous ses éléments par ordre croissant.
On commence par chercher l'indice du plus petit des éléments, soit j cet indice. 
On permute alors les valeurs de a1 et aj .
On cherche ensuite l'indice du plus petit des éléments a2, a3, ..., an et on permute avec a2, etc…
*/
string[] userInput;
int[] arrayAfterConvert;
Console.WriteLine("Nous allons saisir un nombre aléatoire de nombres entier dans le désordre les trier et les afficher dans l'ordre croissant.");
tableToSort();
tableSort();

void tableToSort()
{
    Console.WriteLine("Veuillez enter une serie de nombre entier svp.");
    userInput = Console.ReadLine().Trim().Split(" ");
    arrayAfterConvert=new int[userInput.Length];
    for (int i = 0; i< userInput.Length;i++)
    {
        arrayAfterConvert[i] = int.Parse(userInput[i]);
    }
}// tableau à trier 

void tableSort() 
{
    for (int i = 0; i < arrayAfterConvert.Length; i++)
    {
        for(int j = 0; j < arrayAfterConvert.Length; j++)
        {
            if (arrayAfterConvert[j]> arrayAfterConvert[i]) 
            {
                int temp = arrayAfterConvert[i];
                arrayAfterConvert[i] = arrayAfterConvert[j];
                arrayAfterConvert[j] = temp;
            }
        }
    }
    Console.WriteLine("Voici les nombres classé par ordre croissant");
    foreach (int i in arrayAfterConvert)
    {
        Console.Write(i + " ");
    }
} // tableau trié