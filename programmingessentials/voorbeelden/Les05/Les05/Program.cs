string invoer;
int getal;
DateTime huidigeDatum = default;

huidigeDatum = DateTime.Now;

Console.WriteLine($"De huidige datum is {huidigeDatum}");
do
{
    Console.Write("Geef een getal: ");
    invoer = Console.ReadLine();
}while(!int.TryParse(invoer, out getal) || getal <= 10 );

Console.WriteLine($"Het getal is {getal}");

do
{
    Console.Write("Geef een naam in: ");
    invoer = Console.ReadLine();
}while(string.IsNullOrWhiteSpace(invoer));

Console.WriteLine($"De invoer is {invoer}.");




Console.ReadLine();