int getal, som = 0;

for(int i = 0; i < 10 ; i++)
{
    Console.Write("Geef een getal in: ");
    getal = Convert.ToInt16(Console.ReadLine());

    som += getal;
}
Console.WriteLine($"Som: {som}");

Console.ReadLine();