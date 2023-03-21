/*
 * Il s'agit de dénombrer toutes les personnes d'âge strictement inférieur à 20 ans parmi un échantillon de 20 personnes. 
L’utilisateur est invité à saisir les 20 valeurs.
Décrivez l'algorithme qui affiche le nombre de jeunes et codez la solution.
 */

using System;

string[] age = new string[20];
string userInput;
int[] value = new int[20];
int young = 0;

Console.WriteLine("Nous allons dénombrer sur un pannel de 20 personnes combien ont plus de 20 ans, moins de 20 ans et 20 ans pile.");
Console.WriteLine("Veuillez saisir l'age de 20 personnes en les séparants par un espace svp.");

userInput = Console.ReadLine().Trim(); // .Trim sert à enlever les espaces vide avant et apres la saisie

age = userInput.Split(" ");

for (int i = 0; i < age.Length; i++)
{
    value[i] = int.Parse(age[i]);
}
Console.WriteLine(value.ToString());
foreach (int element in value)
{
    if (element < 20)
    {
        young++;
        
    }
}
Console.WriteLine($"il y a {young} personnes de moins de 20 Ans.");