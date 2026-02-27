// Oef 00
// Variabelen declareren
int breedte, hoogte, omtrek, oppervlakte;

// Lees de breedte in
Console.Write("Geef breedte: ");
breedte = Convert.ToInt16(Console.ReadLine());

// Lees de hoogte in
Console.Write("Geef hoogte: ");
hoogte = Convert.ToInt16(Console.ReadLine());

// Bereken de breedte en de hoogte
omtrek = 2 * breedte + 2 * hoogte;
oppervlakte = breedte * hoogte;

Console.WriteLine($"Omtrek: {omtrek}");
Console.WriteLine($"Oppervlakte: {oppervlakte}");

Console.ReadLine();