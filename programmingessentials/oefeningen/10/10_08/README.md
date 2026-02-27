## 10.08
Lees de naam van een bestand in. Elk bestand heeft 2 rijen met cijfers. Controleer of voor het gegeven bestand de tweede rij van cijfers overeenkomt met de kwadraten van de cijfers uit de eerste rij. Opmerking: de kwadraten mogen in een willekeurige volgorde voorkomen, zolang ze maar allemaal aanwezig zijn. Indien er meerdere kwadraten niet aanwezig zijn, toon je het eerste kwadraat dat ontbreekt.

Voorbeeld van een bestand:
``` csharp
1;2;3
1;4;9
```
Verwachte output:

``` csharp
Correct /* (1*1 = 1) (2*2 = 4) (3*3 = 9) */
```

Voorbeeld van een bestand:
```csharp
1;2;3;4
1;4;9;15
```
Verwachte output: 
```csharp
16 ontbreekt /* (1*1 = 1) (2*2 = 4) (3*3 = 9) (4*4 = 16) */
```
