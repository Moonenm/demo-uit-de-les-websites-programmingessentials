## 02.10
Schrijf een programma dat vraagt welk btw-tarief er van toepassing is en een totaalbedrag. Bereken daarna de prijs inclusief btw en druk deze af. In het geval van een ongeldig btw-tarief, druk je "Ongeldig btw-tarief".

- Btw-tarief van 0% = 1 
- Btw-tarief van 6% = 2 
- Btw-tarief van 12% = 3 
- Btw-tarief van 21% = 4

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Description:** Run 1: args=3, 3098


**Input:**

```
3
3098
```

**Expected Output:**

```
12, totaal: 3469
```

---

### Case 2

**Description:** Run 2: args=7, 4913


**Input:**

```
7
4913
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 3

**Description:** Run 3: args=3, 2352


**Input:**

```
3
2352
```

**Expected Output:**

```
12, totaal: 2634
```

---

### Case 4

**Description:** Run 4: args=6, 4851


**Input:**

```
6
4851
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 5

**Description:** Run 5: args=5, 2952


**Input:**

```
5
2952
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 6

**Description:** Run 6: args=6, 729


**Input:**

```
6
729
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 7

**Description:** Run 7: args=1, 2318


**Input:**

```
1
2318
```

**Expected Output:**

```
0, totaal: 2318
```

---

### Case 8

**Description:** Run 8: args=5, 1918


**Input:**

```
5
1918
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 9

**Description:** Run 9: args=7, 4702


**Input:**

```
7
4702
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 10

**Description:** Run 10: args=7, 644


**Input:**

```
7
644
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 11

**Description:** Run 11: args=6, 1235


**Input:**

```
6
1235
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 12

**Description:** Run 12: args=6, 1183


**Input:**

```
6
1183
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 13

**Description:** Run 13: args=2, 1156


**Input:**

```
2
1156
```

**Expected Output:**

```
6, totaal: 1225
```

---

### Case 14

**Description:** Run 14: args=7, 4845


**Input:**

```
7
4845
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---

### Case 15

**Description:** Run 15: args=7, 4415


**Input:**

```
7
4415
```

**Expected Output:**

```
Ongeldig btw-tarief
```

---
