double prijs = 27.5;

if(prijs > 20)
{
   Console.WriteLine("Groter dan 20"); 
} 

string naam = "Maarten";

// || wil zeggen of
if(naam == "Maarten" || naam == "Sean") 
    Console.WriteLine("De naam is Maarten of Sean");
else if(naam == "Arthur")
    Console.WriteLine("De naam is Arthur");
else
    Console.WriteLine("De naam is iets anders");

// initialiseren
int teller = 0;

// Controleer voorwaarde
while (teller < 10)
{
    // voer code uit
    Console.WriteLine($"De teller is {teller}");

    // Verhoog teller
    teller++;
}

Console.WriteLine($"De teller is {teller}");

// initialiseren ; Controleer voorwaarde ; verhoog teller
for(int i = 0; i < 10 ; i++)
{
    Console.WriteLine($"De teller is {i}");
}
// i is niet bekend buiten de loop
Console.WriteLine($"De teller is {i}");


// opletten dat je de juiste tellers aanpast in de juiste lus!!
int teller2 = 0, teller3 = 10;
while(teller2 < 10)
{
    Console.WriteLine($"{teller2}");
    while(teller3 > 0)
    {
        Console.WriteLine($"{teller3}");
        teller3--;
    }
    teller3++;
}

