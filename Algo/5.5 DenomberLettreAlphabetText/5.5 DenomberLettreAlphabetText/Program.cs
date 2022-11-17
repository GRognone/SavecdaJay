/*
 * Lire un texte d'au moins 120 caractères (à contrôler). 
Compter et afficher le nombre d'occurrences (d'apparitions) de chacune des lettres de l'alphabet.
*/
using System.Text.RegularExpressions; // pour version Gatien.

string userInput;    
char[] alphabet = new char[26];
CreateAlphabetTable();
Console.WriteLine("Lire un texte d'au moins 120 caractères, Compter et afficher le nombre d'occurrences (d'apparitions) de chacune des lettres de l'alphabet.");
ControlUserInput();
//Console.WriteLine(userInput); //c'est juste un outil de control
userInput=ReplaceCharacterAccentRemoval(userInput);
CountAllOccurrence();



void CreateAlphabetTable()
{
    int compteur = 0;
    for (int i = 97; i < (97 + 26); i++)
    {
        alphabet[compteur] = (char)i;
        compteur++;
    }
} // sert à créer automatiquement un d'ableau alphabethique en minuscule.
void ControlUserInput() 
{
    do
    {
        Console.WriteLine("veuillez entrer un texte de 120 caractères minimum svp.");
        userInput = Console.ReadLine();
    }
    while (userInput.Replace(" ","").Length<120);
} // fonction pour creer le texte, le lire et controler sa conformité.
string ReplaceCharacterAccentRemoval(string Texte_a_corriger)
{
    //Conversion du string en tableau de char
    char[] ligne_char = Texte_a_corriger.ToCharArray();
    int mchar;
    for (int i = 0; i < Texte_a_corriger.Length; i++)
    {
        //Conversion du caractere en int
        mchar = (int)ligne_char[i];
        //MAJUSCULES

        // remplacement des accents par A
        if (mchar >= 192 && mchar <= 198)
        {
            ligne_char[i] = 'A';//(char)65;
        }
        else
        // remplacement des accents par E
        if (mchar >= 200 && mchar <= 203)
        {
            ligne_char[i] = 'E';//(char)69;
        }
        else
        // remplacement des accents par I
        if (mchar >= 204 && mchar <= 207)
        {
            ligne_char[i] = 'I';//(char)73;
        }
        else
        // remplacement des accents par O
        if (mchar >= 210 && mchar <= 216 && mchar != 215)
        {
            ligne_char[i] = 'O';//(char)79;
        }
        else
        // remplacement des accents par U
        if (mchar >= 217 && mchar <= 220)
        {
            ligne_char[i] = 'U';//(char)85;
        }
        else
        // remplacement des ç par C
        if (mchar == 199)
        {
            ligne_char[i] = 'C';//(char)67;
        }
        else
        // remplacement des Ð par D
        if (mchar == 208)
        {
            ligne_char[i] = 'D';//(char)68;
        }
        else
        // remplacement des Ñ par N
        if (mchar == 209)
        {
            ligne_char[i] = 'N';//(char)78;
        }
        else
        // remplacement des Ý par Y
        if (mchar == 221)
        {
            ligne_char[i] = 'Y';//(char)89;
        }
        else

        //MINUSCULE
        // remplacement des accents par A
        if (mchar >= 224 && mchar <= 230)
        {
            ligne_char[i] = 'a';//(char)97;
        }
        else
        // remplacement des accents par E
        if (mchar >= 232 && mchar <= 235)
        {
            ligne_char[i] = 'e';//(char)101;
        }
        else
        // remplacement des accents par I
        if (mchar >= 236 && mchar <= 239)
        {
            ligne_char[i] = 'i';//(char)105;
        }
        else
        // remplacement des accents par O
        if (mchar >= 242 && mchar <= 248)
        {
            ligne_char[i] = 'o';//(char)111;
        }
        else
        // remplacement des accents par U
        if (mchar >= 249 && mchar <= 252)
        {
            ligne_char[i] = 'u';//(char)117;
        }
        else
        // remplacement des ç par C
        if (mchar == 231)
        {
            ligne_char[i] = 'c';//(char)99;
        }
        else
        // remplacement des Ð par D
        if (mchar == 208)
        {
            ligne_char[i] = 'd';//(char)100;
        }
        else
        // remplacement des Ñ par N
        if (mchar == 241)
        {
            ligne_char[i] = 'n';//(char)110;
        }
        else
        // remplacement des Ý par Y
        if (mchar == 253 || mchar == 255)
        {
            ligne_char[i] = 'y';//(char)121;
        }
        else
        // remplacement des ° par  
        if (mchar == 176)
        {
            ligne_char[i] = ' ';
        }
    }
    //Conversion du tableau de char[] en string
    return new string(ligne_char);
} // sert à oter tous les accents d'un texte.
void CountAllOccurrence()// sert à faire la comparaison et l'affichage de l'occurence
{
    foreach (char alpha in alphabet)
    {
        int counter = 0;
        foreach(char letter in userInput)
        {
            if (letter == alpha)
            {
                counter++;
            }

        }
        Console.WriteLine($"Il y a {counter} lettres {alpha} dans le texte.");
    }

} //compteur et affichage de l'occurence des lettres de l'alphabet dans un texte.