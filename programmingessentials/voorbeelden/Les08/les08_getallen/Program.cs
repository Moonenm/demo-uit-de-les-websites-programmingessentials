//Variables
int getal1, getal2;
bool isGroter;
string uitvoer;

// Start programma
getal1 = LeesGetal();
getal2 = LeesGetal();

uitvoer = Getal1IsGroterDanGetal2(getal1, getal2) ? $"{getal1} is groter dan {getal2}" : $"{getal1} is kleiner dan {getal2}";

//zelfde maar langer
// isGroter = Getal1IsGroterDanGetal2(getal1, getal2);
// if(isGroter)
// {
//     uitvoer = $"{getal1} is groter dan {getal2}";
// }
// else
// {
//     uitvoer = $"{getal1} is kleiner dan {getal2}";
// }

Console.WriteLine($"De som is {BerekenSom(getal1,getal2)}");
Console.WriteLine(uitvoer);

Console.ReadLine();

// einde programma

//Methods
int BerekenSom(int getal1, int getal2)
{
    return getal1 + getal2;
}

bool Getal1IsGroterDanGetal2(int getal1, int getal2)
{
    return getal1>getal2;
}

int LeesGetal()
{
    string invoer;
    int getal;
    do
    {
        Console.Write("Geef een getal: ");
        invoer = Console.ReadLine();
    }while(!int.TryParse(invoer, out getal));
    return getal;
}