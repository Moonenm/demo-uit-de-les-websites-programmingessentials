//Methode
string LeesBestand(string bestandsnaam)
{
    string uitvoer = string.Empty;
    using StreamReader reader = new(bestandsnaam);
    while (!reader.EndOfStream)
    {
        uitvoer += $"{reader.ReadLine()} \n";
    }
    return uitvoer;
}

void DrukNamen(string namen)
{
    if(string.IsNullOrWhiteSpace(namen))
    {
        Console.WriteLine("Geen vrienden");
    }
    else
    {
        Console.WriteLine($"Vienden \n{namen}");
    }
}

// Main Program
string pad, namen;

Console.Write("Geef de naam van het bestand: ");
pad = Console.ReadLine();

//Controleer of het bestand bestaat
if(!File.Exists(pad))
{
    Console.WriteLine($"{pad} bestaat niet");
    Console.ReadLine();
    return;
}

// Bestand inlezen
namen = LeesBestand(pad);
// Namen afdrukken
DrukNamen(namen);

Console.ReadLine();
