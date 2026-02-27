// See https://aka.ms/new-console-template for more information
int som = 0;
double gemiddelde;
string output;

Console.Write("Geef een eerste getal in: ");
som += Convert.ToInt16(Console.ReadLine());

Console.Write("Geef een tweede getal in: ");
som += Convert.ToInt16(Console.ReadLine());

Console.Write("Geef een derde getal in: ");
som += Convert.ToInt16(Console.ReadLine());

gemiddelde = som / 3;

output = $"Het gemiddelde is {gemiddelde}";

Console.WriteLine(output);

Console.ReadLine();