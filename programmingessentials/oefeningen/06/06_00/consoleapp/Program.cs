//getal inlezen, som van getallen initialiseren (omdat er een bewerking nodig is)
int getal, som = 0;
string invoer;

// Lees een getal in. Het moet een getal zijn.
do
{
    Console.Write("Geef een getal: ");
    invoer = Console.ReadLine();
}while(!int.TryParse(invoer, out getal));

// Zolang getal positief is (groter dan nul)
while(getal > 0)
{
    // Voeg getal toe aan som
    som += getal;

    // Lees het volgende getal in. Het moet een getal zijn.
    do
    {
        Console.Write("Geef een getal: ");
        invoer = Console.ReadLine();
    }while(!int.TryParse(invoer, out getal));
}

Console.WriteLine($"Totaal: {som}");

Console.ReadLine();




















// int getal, som= 0;
// string input;
// do
// {
//     Console.Write("Geef een getal in: ");
//     input = Console.ReadLine();
// }while(!int.TryParse(input, out getal));


// while (getal >0)
// {
//     som += getal;

//     do
//     {
//         Console.Write("Geef een getal in: ");
//         input = Console.ReadLine();
//     }while(!int.TryParse(input, out getal));
// }

// Console.WriteLine($"Totaal: {som}");

// Console.ReadLine();