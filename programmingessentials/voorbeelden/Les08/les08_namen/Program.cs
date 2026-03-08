//Variables
string naam1, naam2, invoer;
List<string> namen = [];

// Start programma
naam1 = LeesNaam();
naam2 = LeesNaam();
ToonNaam(naam1);
ToonNaam(naam2);

invoer = LeesNaam();
while(invoer.ToLower() != "stop")
{
    namen.Add(invoer);
    invoer = LeesNaam();
}

DrukNamen(namen);

Console.ReadLine();

// Einde programma

//Methods
void ToonNaam(string invoer)
{
    Console.WriteLine($"Hello {invoer}");
}

string LeesNaam()
{
    string invoer;
    do
    {
        Console.Write("geef je naam: ");
        invoer = Console.ReadLine();
    }while(string.IsNullOrWhiteSpace(invoer));

    return invoer;
}

void DrukNamen(List<string> lijst)
{
    foreach(string item in lijst)
    {
        Console.WriteLine(item);
    }
}