// Welke variabelen heb ik nodig?
string ploegnaam, symbool1, symbool2, invoer, uitvoer = string.Empty;
int lengte, breedte;

//Lees een ploegnaam in. Deze moet minstens 5 karakters zijn.
do
{
    Console.Write("Geef de ploegnaam: ");
    ploegnaam= Console.ReadLine();
}while(string.IsNullOrWhiteSpace(ploegnaam) || ploegnaam.Length < 5);

// zolang mijn ploegnaam niet 5 asterisken zijn, voeren we de code uit.
while(ploegnaam != "*****")
{
    uitvoer += $"{ploegnaam} \n";

    // Geef symbool 1 in. Het mag maar één karakter zijn.
    do
    {
        Console.Write("Geef symbool 1 in: ");
        symbool1 = Console.ReadLine();
    }while(symbool1.Length != 1 || string.IsNullOrWhiteSpace(symbool1));

    // Geef symbool 2 in. Het mag maar één karakter zijn en mag niet gelijk zijn aan symbool 1
    do
    {
        Console.Write("Geef symbool 2 in: ");
        symbool2 = Console.ReadLine();
    }while(symbool2.Length != 1 || string.IsNullOrWhiteSpace(symbool2) || symbool2 == symbool1); 

    // Lees de lengte in. Deze moet een getal zijn en moet minstens 4 zijn.
    do
    {
        Console.WriteLine("Geef de lengte in: ");
        invoer = Console.ReadLine();
    }while(!int.TryParse(invoer, out lengte) || lengte < 4);

    // Lees de breedte in. Deze moet de helft van de lengte zijn.
    do
    {
        Console.WriteLine("Geef de breedte in: ");
        invoer = Console.ReadLine();
    }while(!int.TryParse(invoer, out breedte) || breedte < lengte / 2 );

    // Druk de sjaal af
    for(int i = 0 ; i < lengte; i++)
    {
        if(i % 2 == 0)
        {
            // maak een nieuwe string met symbool X breedte
            uitvoer += new string(Convert.ToChar(symbool1), breedte);
        }
        else
         {
            uitvoer += new string(Convert.ToChar(symbool2), breedte);
        }  
        uitvoer += "\n";     
    }

    Console.WriteLine(uitvoer);
    
    //Lees een ploegnaam in. Deze moet minstens 5 karakters zijn.
    do
    {
        Console.Write("Geef de ploegnaam: ");
        ploegnaam= Console.ReadLine();
    }while(string.IsNullOrWhiteSpace(ploegnaam) || ploegnaam.Length < 5);
}


Console.ReadLine();




































































// string ploegnaam, karakter1, karakter2, invoer;
// int lengte, breedte;

// do
// {
//     Console.Write("Geef de ploegnaam in: ");
//     ploegnaam = Console.ReadLine();
// }while(string.IsNullOrWhiteSpace(ploegnaam) || ploegnaam.Length<5);

// while(ploegnaam != "*****")
// {
//     do
//     {
//         Console.Write("Geef karakter 1 in: ");
//         karakter1 = Console.ReadLine();
//     }while(string.IsNullOrWhiteSpace(karakter1) || karakter1.Length!=1);

//     do
//     {
//         Console.Write("Geef karakter 2 in: ");
//         karakter2 = Console.ReadLine();
//     }while(string.IsNullOrWhiteSpace(karakter2) || karakter2.Length!=1 || karakter1==karakter2);

//     do
//     {
//         Console.WriteLine("Geef de lengte van de sjaal in: ");
//         invoer = Console.ReadLine();
//     }while(!int.TryParse(invoer, out lengte) || lengte < 4);

//     do
//     {
//         Console.WriteLine("Geef de breedte van de sjaal in: ");
//         invoer = Console.ReadLine();
//     }while(!int.TryParse(invoer, out breedte) || breedte < lengte / 2);

//     for(int i = 0; i<lengte; i++)
//     {
//         if(i%2==0)
//             Console.WriteLine(new string(Convert.ToChar(karakter1), breedte));
//         else
//             Console.WriteLine(new string(Convert.ToChar(karakter2), breedte));
//     }

//     do
//     {
//         Console.Write("Geef de ploegnaam in: ");
//         ploegnaam = Console.ReadLine();
//     }while(string.IsNullOrWhiteSpace(ploegnaam) || ploegnaam.Length<5);
// }

// Console.ReadLine();