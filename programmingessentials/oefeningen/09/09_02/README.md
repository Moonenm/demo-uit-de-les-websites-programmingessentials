## 09.02
Een rekeningnummer bestaat uit 3 groepjes van cijfers met in totaal 12 cijfers, bijvoorbeeld 123-1234567-12.

Schrijf een programma dat controleert of een ingevoerd rekeningnummer correct is.

Een ingegeven rekeningnummer is correct wanneer de laatste 2 cijfers van het rekeningnummer gelijk zijn aan de rest van volgende deling: getal gevormd door de eerste 10 cijfers van het rekeningnummer / 97.

*Maak voor deze oefening gebruik van het datatype `long`.*

Bijvoorbeeld:

Stel volgend rekeningnummer: 979-9315445-55. Het te delen getal is 9799315445. De laatste twee cijfers zijn 55. Indien de rest van volgende deling gelijk is aan 55, is het een geldig rekeningnummer: 9799315445 / 97. Dit is het geval, dit is dus een geldig rekeningnummer.

Stel volgend rekeningnummer: 979-9315445-97. Het te delen getal is 9799315445. De laatste twee cijfers zijn 97. Indien de rest van volgende deling gelijk is aan 97, is het een geldig rekeningnummer: 9799315445 / 97. Dit is niet het geval, dit is dus een ongeldig rekeningnummer.
