





























// string naamEvenement, keuze, naamGebruiker, output;

// do
// {
//     Console.Write("Geef de naam van het evenement: ");
//     naamEvenement = Console.ReadLine();
// }while(string.IsNullOrWhiteSpace(naamEvenement));

// output = $"Aanwezigen voor {naamEvenement}\n";

// do
// {
//     Console.Write("Wil je een naam toevoegen (ja of nee): ");
//     keuze = Console.ReadLine();
// }while(keuze != "ja" && keuze != "nee");

// if(keuze == "nee")
// {
//     output = "Er zijn geen aanwezigen!";
// }
// else
// {  
//     while (keuze == "ja")
//     {
//         Console.Write("Geef de naam van de gebruiker: ");
//         output += $"{Console.ReadLine()} \n";

//         do
//         {
//             Console.Write("Wil je een naam toevoegen (ja of nee): ");
//             keuze = Console.ReadLine().ToLower();
//         }while(keuze != "ja" && keuze != "nee");
//     }
// }

// Console.WriteLine(output);

// Console.ReadLine();