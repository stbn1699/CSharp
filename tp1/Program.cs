Console.WriteLine("");
Console.WriteLine("exercice 1 : ");
Console.WriteLine("");
Console.WriteLine("veuillez entrer le premier nombre : ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("veuillez entrer le deuxieme nombre : ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " est plus grand");
} else {
    Console.WriteLine(secondNumber + " est plus grand");
}
Console.WriteLine("tapez entrer pour passer au suivant");
string ex1 = Console.ReadLine();
Console.Clear();







Console.WriteLine("");
Console.WriteLine("exercice 2 : ");
Console.WriteLine("");
Console.WriteLine("veuillez entrer votre note (/100) : ");
int note = int.Parse(Console.ReadLine());
if (note >= 60)
{
    Console.WriteLine("vous êtes admis(e) !");
} else {
    Console.WriteLine("vous n'êtes pas admis(e) !");
}
Console.WriteLine("tapez entrer pour passer au suivant");
string ex2 = Console.ReadLine();
Console.Clear();






Random aleatoire = new Random();
int findNumber = aleatoire.Next(1, 100);
int nEssai = 0;
bool exit = false;
while (!exit)
{
    Console.WriteLine("");
    Console.WriteLine("exercice 3 : ");
    Console.WriteLine("");
    nEssai++;
    Console.WriteLine("veuillez entrer un nombre (essai n°" + nEssai + ") : " + findNumber);
    int reponse = int.Parse(Console.ReadLine());
    if (reponse == findNumber)
    {
        Console.WriteLine("Correct!");
        exit = true;
        Console.WriteLine("tapez entrer pour passer au suivant");
        string ex3 = Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Incorrect, try again.");
        Console.WriteLine("tapez entrer pour réesayer");
        string ex3Bis = Console.ReadLine();
        Console.Clear();
    }
}
Console.Clear();







Console.WriteLine("");
Console.WriteLine("exercice 4 : ");
Console.WriteLine("");
Console.WriteLine("veuillez entrer un nombre : ");
int timesNumber = int.Parse(Console.ReadLine());
for (int i = 1; i < 13; i++)
{
    int timesResult = timesNumber * i;
    Console.WriteLine(timesNumber + " x " + i + " = " + timesResult);
}
Console.WriteLine("tapez entrer pour passer au suivant");
string ex4 = Console.ReadLine();
Console.Clear();







Console.WriteLine("");
Console.WriteLine("exercice 5 : ");
Console.WriteLine("");
Console.WriteLine("veuillez entrer un nombre : ");
int firstNumberIncr = int.Parse(Console.ReadLine());
Console.WriteLine("veuillez entrer un nombre : ");
int secondNumberIncr = int.Parse(Console.ReadLine());
int resultIncr = firstNumberIncr + secondNumberIncr;
while (resultIncr < 1000)
{
    Console.WriteLine("veuillez entrer un autre nombre (actuellement : " + resultIncr + ") : ");
    int anotherNumberIncr = int.Parse(Console.ReadLine());
    resultIncr = resultIncr + anotherNumberIncr;
}
Console.WriteLine("le nombre est plus grand que 1000!!");
Console.WriteLine("tapez entrer pour passer au suivant");
string ex5 = Console.ReadLine();
Console.Clear();









Console.WriteLine("");
Console.WriteLine("exercice 6 : ");
Console.WriteLine("");
int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(myArray[i]);
}
Console.WriteLine("tapez entrer pour passer au suivant");
string ex6 = Console.ReadLine();
Console.Clear();









Console.WriteLine("");
Console.WriteLine("exercice 7 : ");
Console.WriteLine("");
int[] ex7Array = new int[10];
for (int i = 1; i < 11; i++)
    
{
    Console.WriteLine("veuillez entrer le nombre n°" + i + " : ");
    int position = -1 + i;
    ex7Array[position] = int.Parse(Console.ReadLine());
}

foreach (var value in ex7Array)
{
    Console.WriteLine(value);
}
Console.WriteLine("tapez entrer pour passer au suivant");
string ex7 = Console.ReadLine();
Console.Clear();









Console.WriteLine("");
Console.WriteLine("exercice 8 : ");
Console.WriteLine("");
string[] ex8Array = { "bleu", "orange", "rouge", "vert", "violet" };
int i = 0;
while (i < ex8Array.Length)
{
    Console.WriteLine(ex8Array[i]);
    i++;
}
Console.WriteLine("");
Console.WriteLine("tapez entrer pour passer au suivant");
string ex8 = Console.ReadLine();
Console.Clear();









Console.WriteLine("");
Console.WriteLine("exercice 9 : ");
Console.WriteLine("");

double[] ex9Array = { 1.5, 2.5, 3.5, 4.5, 5.5 };
int i = 0;
double result = 0;
do
{
    result = result + ex9Array[i];
    Console.WriteLine(result);
    i++;
} while (i < ex9Array.Length);

Console.WriteLine("");
Console.WriteLine("tapez entrer pour passer au suivant");
string ex9 = Console.ReadLine();
Console.Clear();