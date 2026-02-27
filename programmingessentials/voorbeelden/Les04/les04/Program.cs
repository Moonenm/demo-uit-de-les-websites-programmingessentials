//Voorbeeld van les 4

// Eerste deel = declaratie van de teller (i) en initialisatie
// Tweede deel = vergelijking (voldoet mijn teller aan de voorwaarde )
// Derde deel = verhoog de teller (stapgrootte) i++ --> verhoogte met één, i+=2 --> verhoogt met twee
int aantal, beginwaarde;
Console.Write("Hoeveel keer wil je iets afdrukken? ");
aantal = Convert.ToInt16(Console.ReadLine());

Console.Write("Geef de beginwaarde ");
beginwaarde = Convert.ToInt16(Console.ReadLine());

for(int i = beginwaarde; i < beginwaarde + aantal; i++)
{
    Console.WriteLine($"We zitten nu op nr {i}");
}

Console.ReadLine();
