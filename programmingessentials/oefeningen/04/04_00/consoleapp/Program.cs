int getal;

Console.Write("Geef een getal in: ");
getal = Convert.ToInt16(Console.ReadLine());

for(int i = getal + 1 ; i < getal + 11 ; i++)
{
    Console.WriteLine(i);
}

Console.ReadLine();
