string keuze, invoer, bestelling;
int menuKeuze;
Console.WriteLine("Welkom bij Mc Maarten.");

bestelling = "Bestelling \n";

do
{
    Console.Write("Wil je graag iets bestellen? ");
    keuze = Console.ReadLine(); 
}while(string.IsNullOrWhiteSpace(keuze));

while(keuze == "ja")
{
    Console.WriteLine("Menukaart:");
    Console.WriteLine("1. Big Maarten");
    Console.WriteLine("2. CheeseBurger");
    Console.WriteLine("3. Vegan Burger");
    do
    {
        Console.Write("Wat wil je graag bestellen? ");
        invoer = Console.ReadLine();   
    }while(!int.TryParse(invoer, out menuKeuze));

    switch(menuKeuze)
    {
        case 1:
            bestelling += "Big Maarten \n";
            break;
        case 2: 
            bestelling += "Cheeseburger \n";
            break;
        case 3: 
            bestelling += "Vegan Burger \n";
            break;
    }
    Console.Clear();
    Console.WriteLine(bestelling);

    do
    {
        Console.Write("Wil je nog iets bestellen? ");
        keuze = Console.ReadLine(); 
    }while(string.IsNullOrWhiteSpace(keuze));
}

Console.WriteLine(bestelling);

Console.ReadLine();