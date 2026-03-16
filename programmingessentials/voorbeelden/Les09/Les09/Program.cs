// Substring()
// Insert()
// Replace()
// Trim()
// IndexOf()
// LastIndexOf()
// Split()

string tekst = "Dit is een voorbeeld";
string tekst2 = "   01234;Maarten;r0123456    ";
string tekst3 = "10,25,36,19";
string[] woordenArray = [];
List<string> woordenLijst = [];

// Substring begint op een bepaalde plaats en neemt het aantal karakters.
Console.WriteLine($"{tekst.Substring(10,4)}");

// Loop door de tekst, letter voor letter
for(int i = 0; i < tekst.Length; i++)
{
    Console.Write($"{tekst.Substring(i,1)} ");
}
Console.WriteLine();

// Insert gaat een stuk tekst toevoegen op een bepaalde plaats.
// strings zijn imuutbaar --> een methode past de tekst niet aan. Je moet
// de oude waarde overschrijven of bewaren in een nieuwe variabele.
Console.WriteLine($"{tekst.Insert(11, "goed ")}");
tekst = tekst.Insert(11, "goed ");
Console.WriteLine(tekst);

// Replace gaat een stuk tekst vervangen
Console.WriteLine($"{tekst.Replace("goed", "slecht")}");

// Trim gaat spaties voor en achter de tekst verwijderen
Console.WriteLine(tekst2);
Console.WriteLine(tekst2.Trim());
tekst2 = tekst2.Replace(" ", "*");
Console.WriteLine(tekst2);

// IndexOf()
Console.WriteLine($"{tekst.IndexOf("goed")}");

// LastIndexOf()
Console.WriteLine($"{tekst.LastIndexOf("d")}");

// Split() gaat een tekst uitelkaar splitsen in een array van strings.
woordenArray = tekst.Split(" ");
foreach(string woord in woordenArray)
{
    Console.WriteLine(woord);
}

for(int i = 0 ; i < woordenArray.Count(); i++)
{
    Console.WriteLine($"Woord {i}: {woordenArray[i]}");
    woordenArray[i] = new string('*', woordenArray[i].Length);
}

foreach(string woord in woordenArray)
{
    Console.WriteLine(woord);
}
woordenLijst = [.. tekst.Split(" ")];


Console.ReadLine();