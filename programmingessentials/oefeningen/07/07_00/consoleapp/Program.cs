// Declareer de lijst van namen
List<string> namen = [];
string invoer;

// do while om invoer te controleren -- > mag niet leeg zijn en moet ja of nee zijn
do
{
    Console.Write("Wil je een naam toevoegen aan de lijst? ");
    invoer = Console.ReadLine();
}while(string.IsNullOrWhiteSpace(invoer) || invoer != "ja" && invoer != "nee");

// while loop om iets oneindig keer te herhalen tot bepaald voorwaarde voldaan is.
while (invoer == "ja")
{

    // do while gebruiken om te controleren dat de naam niet leeg is.
    do
    {
        Console.Write("Geef een naam in: ");
        invoer = Console.ReadLine();
    }while(string.IsNullOrWhiteSpace(invoer));
    
    // invoer toevoegen aan de list namen
    namen.Add(invoer);

    // opnieuw vragen om een naam toe te voegen (invoer mag niet leeg zijn)
    do
    {
        Console.Write("Wil je een naam toevoegen aan de lijst? ");
        invoer = Console.ReadLine();
    }while(string.IsNullOrWhiteSpace(invoer) || invoer != "ja" && invoer != "nee");
}
//Druk titel af
Console.WriteLine("Namen: ");

// Druk alle namen in de lijst af. --> loop door de lijst en
// druk alle elementen in de lijst af.
foreach(string naam in namen)
{
    Console.WriteLine(naam);
}

Console.ReadLine();

