// See https://aka.ms/new-console-template for more information
int getal, leeftijd, huisnummer, saldo; //gehele getallen 12 356
string naam, adres, voornaam, diploma; // eender welke tekst "Straat 15"
double prijs; 
bool isGelijk;
char letter;
DateTime geboorteDatum;

Console.Write("Geef het adres: ");
adres = Console.ReadLine(); // "straat 15" Console.ReadLine() geeft altijd een string terug

Console.Write("Geef de leeftijd: ");
leeftijd = Convert.ToInt32(Console.ReadLine()); 
// ToInt16 --> -32K tot +32K 
// ToInt32 --> -2 miljard tot + 2 miljard
// afhankelijk van wat je verwacht als input.

// in plaats van Convert.To... kun je ook 'datatype'.Parse gebruiken
leeftijd = int.Parse(Console.ReadLine());
prijs = double.Parse(Console.ReadLine());
letter = char.Parse(Console.ReadLine());
// leeftijd, prijs en letter zijn variabelen

// Elke methode heeft haakjes! Niet elke methode heeft parameters(argumenten)
Console.ReadLine();
// "Tekst" is een parameter
Console.WriteLine("Tekst");
// invoer en out getal zijn parameters 
// int.TryParse(invoer, out getal)
naam = Console.ReadLine().ToUpper();

// elke bewerking met een variabele, die niet ingegeven is door een gebruiker, vereist een initialisatie 
string naam;
// Onderstaande lijn werkt niet omdat naam null is. Daarom initialiseren --> string naam = "Maarten"
Console.WriteLine(naam);



Console.ReadLine();