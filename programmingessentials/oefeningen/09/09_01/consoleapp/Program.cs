string invoer;
int som = 0, cijfer;

Console.Write("Geef een getal in: ");
invoer = Console.ReadLine();

for(int i = 0; i < invoer.Length; i++)
{
    cijfer = int.Parse(invoer.Substring(i,1));
    som += cijfer;
}

Console.WriteLine(som);

Console.ReadLine();