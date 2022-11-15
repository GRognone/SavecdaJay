/*
 * Soit "X" une valeur à convertir.
Formule °F vers °C : °C = (X − 32) 𝟓/9

Formule °C vers °F : °F = (X 𝟗/5) + 32

L'utilisateur saisit une valeur numérique comprise entre -459.67 et 5 000 000 suivi de l'unité de température : 
▪ C pour Celsius
▪ F pour Fahrenheit
La valeur et l'unité de température sont séparés par un espace (exemple: 32 C pour 32 degrés Celsius). Si la valeur est hors limite, 
l’utilisateur est invité à saisir une nouvelle valeur. 
Le programme affiche le résultat de la conversion sous forme de nombre réel double précision.
Pour information, le zéro absolu correspond à -459.67 Degrés Fahrenheit ou -273.15 degrés Celsius. 
En physique, rien ne peut être plus froid que le zéro absolu !
La température de la plus basse jamais enregistrée sur Terre est -95 degrés Celsius.
*/
string[] userInput = new string[2];
double convertResult;


Console.WriteLine("Veuillez entrer une valeur à convertir separé d'un espace suivi du symbole F pour convertir de fahrenheit en degrès ou C pour convertir du degres en fahrenheit");
userInput[0] = Console.ReadLine();
