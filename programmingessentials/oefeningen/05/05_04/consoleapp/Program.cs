string input, juistAntwoord;
int pogingen = 0;

juistAntwoord = "Op de stoel ligt een zonnehoed en peperkoek";

Console.WriteLine($"Onthoud deze tekst: \n {juistAntwoord}");
Console.ReadLine();
Console.Clear();

do
{
    Console.Write("Raad de zin: ");
    input = Console.ReadLine();

    pogingen++;
}while(input != juistAntwoord);

if(pogingen == 1)
    Console.WriteLine($"Je had 1 poging nodig!");
else
    Console.WriteLine($"Je had {pogingen} pogingen nodig!");

Console.ReadLine();