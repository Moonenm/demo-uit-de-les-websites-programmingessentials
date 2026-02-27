## 02.03
Lees een voornaam, familienaam en leeftijd in. De leeftijdsgroep wordt nu bepaald. Iemand hoort bij de leeftijdsgroep "Jeugd" als hij/zij jonger is dan 18, in het andere geval behoort hij/zij tot de leeftijdsgroep "Volwassenen".

Opmerking: er mag geen gebruik gemaakt worden van een else-tak.

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Description:** Run 1: args=Kathleen, Verdonck, 26


**Input:**

```
Kathleen
Verdonck
26
```

**Expected Output:**

```
Kathleen Verdonck: Volwassenen
```

---

### Case 2

**Description:** Run 2: args=Elisabeth, Vandenbroucke, 17


**Input:**

```
Elisabeth
Vandenbroucke
17
```

**Expected Output:**

```
Elisabeth Vandenbroucke: Jeugd
```

---

### Case 3

**Description:** Run 3: args=Maria, Verheyden, 16


**Input:**

```
Maria
Verheyden
16
```

**Expected Output:**

```
Maria Verheyden: Jeugd
```

---

### Case 4

**Description:** Run 4: args=Tom, Michiels, 4


**Input:**

```
Tom
Michiels
4
```

**Expected Output:**

```
Tom Michiels: Jeugd
```

---

### Case 5

**Description:** Run 5: args=Oscar, Verhaegen, 12


**Input:**

```
Oscar
Verhaegen
12
```

**Expected Output:**

```
Oscar Verhaegen: Jeugd
```

---

### Case 6

**Description:** Run 6: args=Ronny, Heylen, 23


**Input:**

```
Ronny
Heylen
23
```

**Expected Output:**

```
Ronny Heylen: Volwassenen
```

---

### Case 7

**Description:** Run 7: args=Natacha, Stevens, 3


**Input:**

```
Natacha
Stevens
3
```

**Expected Output:**

```
Natacha Stevens: Jeugd
```

---

### Case 8

**Description:** Run 8: args=Walter, Engelen, 7


**Input:**

```
Walter
Engelen
7
```

**Expected Output:**

```
Walter Engelen: Jeugd
```

---

### Case 9

**Description:** Run 9: args=Diana, Huys, 13


**Input:**

```
Diana
Huys
13
```

**Expected Output:**

```
Diana Huys: Jeugd
```

---

### Case 10

**Description:** Run 10: args=Viviane, De Baets, 2


**Input:**

```
Viviane
De Baets
2
```

**Expected Output:**

```
Viviane De Baets: Jeugd
```

---

### Case 11

**Description:** Run 11: args=Maria, De Bruyn, 2


**Input:**

```
Maria
De Bruyn
2
```

**Expected Output:**

```
Maria De Bruyn: Jeugd
```

---

### Case 12

**Description:** Run 12: args=Pieter, Coenen, 29


**Input:**

```
Pieter
Coenen
29
```

**Expected Output:**

```
Pieter Coenen: Volwassenen
```

---

### Case 13

**Description:** Run 13: args=Max, Van Baelen, 13


**Input:**

```
Max
Van Baelen
13
```

**Expected Output:**

```
Max Van Baelen: Jeugd
```

---

### Case 14

**Description:** Run 14: args=Werner, Gillis, 7


**Input:**

```
Werner
Gillis
7
```

**Expected Output:**

```
Werner Gillis: Jeugd
```

---

### Case 15

**Description:** Run 15: args=Elsa, Lammens, 21


**Input:**

```
Elsa
Lammens
21
```

**Expected Output:**

```
Elsa Lammens: Volwassenen
```

---
