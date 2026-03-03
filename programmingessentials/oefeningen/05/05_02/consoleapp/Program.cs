int prijs, totaalPrijs = 0;
string invoer;

for(int i = 0; i < 5 ; i++ )
{
    do
    {
        Console.Write($"Geef de prijs van artikel {i+1}: ");
        invoer = Console.ReadLine();
    }while(!int.TryParse(invoer, out prijs));
    totaalPrijs += prijs;
}


