string pad;
List<string> bestand = [];
List<int> bestandInt = [];
int som = 0;

Console.Write("Geef de naam van het bestand: ");
pad=Console.ReadLine();

// Controleren of het bestand bestaat.
if(!File.Exists(pad))
{
    Console.WriteLine($"{pad} bestaat niet");
    //Stop hier het programma!
    Console.ReadLine();
    return;
}

//Bestand inlezen als tekst
using StreamReader reader = new(pad);
while(!reader.EndOfStream)
{
    bestand.Add(reader.ReadLine());
}

// Belangrijk! het bestand is nu een lijst van strings! dus handmatig som berekenen met foreach!
foreach(string record in bestand)
{
    // som+= Convert.ToInt16(record);
    som += int.Parse(record);
}

//Bestand inlezen
// using StreamReader reader2 = new(pad);
// while(!reader2.EndOfStream)
// {
//     bestandInt.Add(int.Parse(reader.ReadLine()));
// }

// som = bestandInt.Sum();

Console.WriteLine("Som");
Console.WriteLine(som);


// lijst bestand afdrukken
// foreach(string record in bestand)
// {
//     Console.WriteLine(record);
// }



Console.ReadLine();