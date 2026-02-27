int getal = 10;
int getal2 = 20, getal3= 40;
string naam1 = "Gabriël", naam2;
bool isGelijk = true;

if(isGelijk)
{
    Console.WriteLine("Dit is \"heel\" lange tekst. \n Dit is een nieuwe regel");
}
else
{
    //doe something
}


// if(getal>10 || getal2 >10)
// {
//    getal3 = getal + getal2;
//    naam1 = "Victor";
//    Console.WriteLine($"{naam1} heeft {getal3} auto's."); 
// }
// else
// {
//     Console.WriteLine("Vanalles");
// }

// if(getal > 0)
// {
//     Console.WriteLine("Getal is groter dan 0");
// }
// else if(getal <-10)
// {
//     Console.WriteLine("Getal is kleiner dan -10");
// }
// else if(getal2 >20)
// {
//     Console.WriteLine("Getal is kleiner dan 0 maar groter dan -10 en getal2 is groter dan 20");
// }
// if(getal > 0)
// {
//     Console.WriteLine("Het getal is groter dan 0.");
// }
// else
// {
//     Console.WriteLine("Het getal is niet groter dan 0.");
// }

// if(getal2 == getal3)
// {
//     Console.WriteLine("Het getal2 is gelijk aan getal3.");
// }
// else
// {
//     Console.WriteLine("Het getal2 is niet gelijk aan getal3.");
// }

// Console.Write("Geef een getal in: ");
// getal = Convert.ToInt16(Console.ReadLine());

// if(getal-10 >= 0)
// {
//     Console.WriteLine($"{getal} is groter dan of gelijk aan 0");
// }

// Console.Write("Geef een naam in: ");
// naam2 = Console.ReadLine();

// if(naam1==naam2)
// {
//     Console.WriteLine($"{naam1} is gelijk aan {naam2}.");
// }
// else
// {
//     Console.WriteLine($"{naam1} is niet gelijk aan {naam2}.");
// }

// De laatste regel is altijd Console.ReadLine om niet direct de Console af
// te sluiten

bool isGroot;
int grootte;

Console.Write("Hoe groot ben je (in cm)? ");
grootte = Convert.ToInt16(Console.ReadLine());

if(grootte > 180) 
    isGroot = true;
else
    isGroot = false;

if(isGroot)
    Console.WriteLine("Je bent groot!");
else
    Console.WriteLine("Je bent niet zo groot.");

if(grootte == 180) Console.WriteLine("Je bent 180 cm.");
if(grootte != 180) Console.WriteLine("Je bent geen 180 cm.");
if(grootte >= 180) Console.WriteLine("Je bent groter dan of gelijk aan 180 cm.");
if(grootte < 180) Console.WriteLine("Je bent kleiner dan 180 cm.");

if(grootte > 180 && grootte < 190) Console.WriteLine("Je bent tussen een 180 en 190 cm.");
if(grootte == 180 || grootte == 190) Console.WriteLine("Je bent 180 of 190cm.");

int spelers;

Console.Write("Met hoeveel spelers ben je? ");
spelers = int.Parse(Console.ReadLine());

if (spelers < 1) Console.WriteLine("Ongeldig aantal spelers.");
else if (spelers == 1) Console.WriteLine("Speel: Solitaire");
else if (spelers == 2) Console.WriteLine("Speel: Schaken");
else if (spelers <= 4) Console.WriteLine("Speel: Catan");
else Console.WriteLine("Speel: Weerwolven");


Console.ReadLine();