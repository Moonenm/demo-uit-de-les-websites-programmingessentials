int getal1, getal2;
string invoer;

do
{
    Console.Write("Geef getal 1: ");
    invoer = Console.ReadLine();
}while(!int.TryParse(invoer, out getal1));

do
{
    Console.Write("Geef getal 2: ");
    invoer = Console.ReadLine();
}while(!int.TryParse(invoer, out getal2));

if(getal1 > getal2 )
    Console.WriteLine($"{getal1} - {getal2} = {getal1-getal2}");
else
    Console.WriteLine($"{getal2} - {getal1} = {getal2-getal1}");

Console.ReadLine();