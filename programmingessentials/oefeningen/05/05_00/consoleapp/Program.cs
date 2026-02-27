double aantalMg, totaleTijd = 0;
string invoer;

do
{
   Console.Write("Geef het aantal mg koffie: ");
   invoer = Console.ReadLine(); 
}while(!double.TryParse(invoer, out aantalMg));

do
{
    aantalMg /= 2;
    totaleTijd += 5;

    // totaleTijd = totaleTijd + 5
}while(aantalMg >= 1);

Console.WriteLine($"Totale tijd: {totaleTijd} uur");

Console.ReadLine();
