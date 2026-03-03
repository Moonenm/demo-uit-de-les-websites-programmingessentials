//Lists
// **************************************************
// Dit is een list van integers en we zetten er al wat waarden in (initialiseren)
List<int> getallen3 = [15, 356, 4, 19, 768];
// Dit is een list van integers maar er zit nog niets in.
List<int> getallen4 = []; 

// Waarden toevoegen aan de list met behulp van de methode .Add()
getallen4.Add(10);
getallen4.Add(17);
getallen4.Add(20);

// for loop gebruiken om door de getallen weer te geven.
// getallen4.Count --> aantal getallen in de rij
// 
for(int i = 0; i < getallen4.Count; i++)
{
    Console.WriteLine($"Getal {i+1}: {getallen4[i]} ");
}

Console.WriteLine();

// maak een nieuwe lijst van string en initialiseer met []
List<string> namen = [];

// 5 Namen in lezen met een forloop
for(int i = 0 ; i < 5; i++)
{
    Console.Write($"Geef naam {i+1}: ");
    namen.Add(Console.ReadLine());
}

// Namen afdrukken met een foreach
foreach(string naam in namen)
{
    Console.Write($"{naam} ");
}

// Methode Reverse() gebruiken om de waarden in de list om te draaien
namen.Reverse();
// Methode Sort() gebruiken om de waarden te sorteren.
namen.Sort();

// Haal het kleinste getal uit de lijst en bewaar dit in de variabele minimum
int minimum = getallen4.Min();
int maximum = getallen4.Max();
double gemiddelde = getallen4.Average();
int som = getallen4.Sum();

Console.WriteLine($"De som is {getallen4.Sum()}");

// Gaat true teruggeven als de list de naam Maarten bevat.
bool gevonden = namen.Contains("Maarten");

// Gaat de index teruggeven van de plaats waar de eerste Maarten gevonden wordt.
int plaatsNaam = namen.IndexOf("Maarten");

// Verwijder in de lijst de gegeven op plaats (index).
namen.RemoveAt(plaatsNaam);

// Namen afdrukken met een foreach
foreach(string naam in namen)
{
    Console.Write($"{naam} ");
}


Console.ReadLine();


// IEnumerable
IEnumerable<int> getallen5;
//getallen5.Count;

// Arrays
// ****************************************************
// Dit is een array van 4 getallen
int[] getallen = [1,3,6,10];

getallen.Count();

// Array van getallen maar je weet nog niet op voorhand welke getallen.
int[] getallen2 = new int[5];

// een array opvullen
getallen2[0] = 10;
getallen2[4] = 20;
getallen2[0] = 30;


//Oude manier --> 5 getallen inlezen = heel veel herhaalwerk
// int getal1, getal2, getal3, getal4, getal5;

// Console.Write("Geef getal1: ");
// getal1 = Convert.ToInt16(Console.ReadLine());
// Console.Write("Geef getal1: ");
// getal2 = Convert.ToInt16(Console.ReadLine());
// Console.Write("Geef getal1: ");
// getal3 = Convert.ToInt16(Console.ReadLine());
// Console.Write("Geef getal1: ");
// getal4 = Convert.ToInt16(Console.ReadLine());
// Console.Write("Geef getal1: ");
// getal5 = Convert.ToInt16(Console.ReadLine());
