char letter;

Console.Write("Geef een letter in: ");
letter = Convert.ToChar(Console.ReadLine().ToLower());

if(letter == 'a' || letter == 'e' ||letter == 'i' || letter == 'o' || letter == 'u')
{
    Console.WriteLine($"Letter {letter} is een klinker");
}
else
{
    Console.WriteLine($"Letter {letter} is een medeklinker");
}

Console.ReadLine();