// variabelen declareren
string zin;
int aantalKlinkers = 0;

// zin inlezen
Console.Write("Geef een zin: ");
zin = Console.ReadLine().ToLower();

for(int i = 0 ; i < zin.Length; i++)
{
    if(zin.Substring(i,1) == "a" ||  zin.Substring(i,1) == "e" ||   
        zin.Substring(i,1) == "i" || zin.Substring(i,1) == "o" || 
        zin.Substring(i,1) == "u" )
    {
        aantalKlinkers++;
    }
}

Console.WriteLine(aantalKlinkers);

// console openhouden
Console.ReadLine();