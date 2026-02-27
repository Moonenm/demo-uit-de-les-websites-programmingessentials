int aantalSpelers;

Console.Write("Geef het aantal spelers: ");
aantalSpelers = Convert.ToInt16(Console.ReadLine());

switch(aantalSpelers)
{
    case 1:
        Console.WriteLine("Solitaire");
        break;
    case 2:
        Console.WriteLine("Schaken");
        break;
    case 3:
    case 4:
        Console.WriteLine("Catan");
        break; 
    default:
        Console.WriteLine("Weerwolven");
        break;
}


Console.ReadLine();

// string naam = "Maarten";

// Console.Write("Geef je naam in: ");
// naam = Console.ReadLine().ToUpper();

// if(naam=="MAARTEN")
// {
//     if(naam=="TEST")
//     {
//         if(naam=="TEST3")
//         {
            
//         }

//     }
// }
