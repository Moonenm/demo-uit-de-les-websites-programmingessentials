string input;
// Onderstaande variabelen worden niet ingelezen dus ... initialiseren.
int aantalPassagiers=0, aantalAanRaam=0;

//herhaal tot aantal aan raam = 4 of aantal passagiers = 8
do
{
    // lees een passagier in (enkel Y of N is toegestaan)
    do
    {
        Console.Write("Wens je een plaats aan het raam: ");
        input = Console.ReadLine().ToUpper();
    }while(string.IsNullOrWhiteSpace(input) || input != "Y" && input !="N");

    // raampassagiers verhogen
    if(input == "Y")
        aantalAanRaam++;

    // aantal passagiers verhogen
    aantalPassagiers++;

}while(aantalAanRaam != 4 && aantalPassagiers != 8);

//Er zijn 4 passagiers.
//4 zitten er aan het raam.
Console.WriteLine($"Er zijn {aantalPassagiers} passagiers.");
Console.WriteLine($"{aantalAanRaam} zitten er aan het raam.");

Console.ReadLine();
