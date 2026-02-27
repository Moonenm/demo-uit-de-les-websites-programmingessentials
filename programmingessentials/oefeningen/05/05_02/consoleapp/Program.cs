int prijs;
string invoer;

for(int i = 1; i < 6 ; i++ )
{
    do
    {
        Console.Write($"Geef de prijs van artikel {i}: ");
        invoer = Console.ReadLine();
    }while(!int.TryParse(invoer, out prijs));
    totaalPrijs += ....
}
