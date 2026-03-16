// Methodes
List<string> LeesBestand(string bestandsNaam)
{
    List<string> bestand = [];
    using StreamReader reader = new(bestandsNaam);
    while(!reader.EndOfStream)
    {
        bestand.Add(reader.ReadLine());
    }
    return bestand;
}

void VerwerkBestand(List<string> bestand)
{
    foreach(string record in bestand)
    {
        DrukSjaal(record);
    }
}

void DrukSjaal(string record)
{
    string [] regel = [];
    string clubNaam, lijnEven, lijnOneven;
    char symbool1, symbool2;
    int lengte, breedte;
    
    regel = record.Split(";");

    clubNaam = regel[0];
    symbool1 = Convert.ToChar(regel[1]);
    symbool2 = Convert.ToChar(regel[2]);
    lengte = int.Parse(regel[3]);
    breedte = int.Parse(regel[4]);

    lijnEven = new string (symbool1, breedte);
    lijnOneven = new string (symbool2, breedte);

    // Onderstaande code zou eigenlijk in een aparte methode moeten
    Console.WriteLine($"Sjaal {clubNaam}");
    Console.WriteLine(new string('*',clubNaam.Length+6));

    for(int i = 0; i< lengte ; i++)
    {
        if(i%2==0)
        {
            Console.WriteLine(lijnEven);
        }
        else
        {
            Console.WriteLine(lijnOneven);
        }
    }
}

// Main Program
string pad;
List<string> bestand = [];

// Lees de naam in van het bestand.
Console.Write("Geef de naam van het bestand: ");
pad = Console.ReadLine();

// Controleer of het bestand bestaat.
if(!File.Exists(pad))
{
    Console.WriteLine($"{pad} bestaat niet");
    Console.ReadLine();
    return;
}

bestand = LeesBestand(pad);

// bestand.Count --> is het aantal elementen in mijn lijst gelijk aan 0, dan is de lijst leeg

if(bestand.Count == 0)
{
    Console.Write("Het bestand is leeg");
}
else
{
    VerwerkBestand(bestand);
}

Console.ReadLine();
