// Voorbeeld 1
List<int> getallen = new List<int> { 8, 3, 12, 5, 1 };

int maximum = getallen[0];

for (int i = 1; i < getallen.Count; i++)
{
    if (getallen[i] > maximum)
    {
        maximum = getallen[i];
    }
}

Console.WriteLine($"Het maximum is: {maximum}");

// Voorbeeld2
List<int> getallen = new List<int> { 8, 3, 12, 5, 1 };
int hulpGetal;

for (int i = 0; i < getallen.Count - 1; i++)
{
    for (int j = 0; j < getallen.Count - i - 1; j++)
    {
        if (getallen[j] > getallen[j + 1])
        {
            hulpGetal = getallen[j];
            getallen[j] = getallen[j + 1];
            getallen[j + 1] = hulpGetal;
        }
    }
}

foreach (int getal in getallen)
{
    Console.Write($"{getal} ");
}

// Voorbeeld3
List<string> namen= [];
string invoer;

do
{
    Console.Write("Geef naam 1: ");
    invoer= Console.ReadLine();
}while(string.IsNullOrWhiteSpace(invoer));

while(invoer != "*****")
{
    namen.Add(invoer);

    do
    {
        Console.Write("Geef de volgende naam: ");
        invoer= Console.ReadLine();
    }while(string.IsNullOrWhiteSpace(invoer));    
}

foreach(string naam in namen)
{
    Console.Write($"{naam} ");
}

Console.ReadLine();