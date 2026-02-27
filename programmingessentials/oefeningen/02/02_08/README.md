## 02.08
Schrijf een programma dat een bedrag in euro inleest en daarna een wisselkoers (GBP of USD), toon de gebruiker het omgerekende bedrag in de wisselkoers die hij/zij bepaald heeft. Indien de gebruiker een verkeerde wisselkoers ingeeft, toon je "Foutieve wisselkoers".
- 1 EUR is gelijk aan 1,08 GBP
- 1 EUR is gelijk aan 0,77 USD

## Fuzz Test Cases

Below are the automatically generated input/output expectations.

---

### Case 1

**Description:** Run 1: args=196, GBP


**Input:**

```
196
GBP
```

**Expected Output:**

```
GBP: 211.68
```

---

### Case 2

**Description:** Run 2: args=74, USD


**Input:**

```
74
USD
```

**Expected Output:**

```
USD: 56.98
```

---

### Case 3

**Description:** Run 3: args=28, YEN


**Input:**

```
28
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 4

**Description:** Run 4: args=164, YEN


**Input:**

```
164
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 5

**Description:** Run 5: args=176, USD


**Input:**

```
176
USD
```

**Expected Output:**

```
USD: 135.52
```

---

### Case 6

**Description:** Run 6: args=73, YEN


**Input:**

```
73
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 7

**Description:** Run 7: args=55, USD


**Input:**

```
55
USD
```

**Expected Output:**

```
USD: 42.35
```

---

### Case 8

**Description:** Run 8: args=153, GBP


**Input:**

```
153
GBP
```

**Expected Output:**

```
GBP: 165.24
```

---

### Case 9

**Description:** Run 9: args=166, YEN


**Input:**

```
166
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 10

**Description:** Run 10: args=73, USD


**Input:**

```
73
USD
```

**Expected Output:**

```
USD: 56.21
```

---

### Case 11

**Description:** Run 11: args=74, YEN


**Input:**

```
74
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 12

**Description:** Run 12: args=58, GBP


**Input:**

```
58
GBP
```

**Expected Output:**

```
GBP: 62.64
```

---

### Case 13

**Description:** Run 13: args=29, USD


**Input:**

```
29
USD
```

**Expected Output:**

```
USD: 22.33
```

---

### Case 14

**Description:** Run 14: args=103, YEN


**Input:**

```
103
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 15

**Description:** Run 15: args=69, USD


**Input:**

```
69
USD
```

**Expected Output:**

```
USD: 53.13
```

---

### Case 16

**Description:** Run 16: args=96, USD


**Input:**

```
96
USD
```

**Expected Output:**

```
USD: 73.92
```

---

### Case 17

**Description:** Run 17: args=84, YEN


**Input:**

```
84
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 18

**Description:** Run 18: args=151, GBP


**Input:**

```
151
GBP
```

**Expected Output:**

```
GBP: 163.08
```

---

### Case 19

**Description:** Run 19: args=70, YEN


**Input:**

```
70
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 20

**Description:** Run 20: args=36, GBP


**Input:**

```
36
GBP
```

**Expected Output:**

```
GBP: 38.88
```

---

### Case 21

**Description:** Run 21: args=182, USD


**Input:**

```
182
USD
```

**Expected Output:**

```
USD: 140.14
```

---

### Case 22

**Description:** Run 22: args=193, YEN


**Input:**

```
193
YEN
```

**Expected Output:**

```
Foutieve wisselkoers
```

---

### Case 23

**Description:** Run 23: args=83, GBP


**Input:**

```
83
GBP
```

**Expected Output:**

```
GBP: 89.64
```

---

### Case 24

**Description:** Run 24: args=126, GBP


**Input:**

```
126
GBP
```

**Expected Output:**

```
GBP: 136.08
```

---

### Case 25

**Description:** Run 25: args=138, GBP


**Input:**

```
138
GBP
```

**Expected Output:**

```
GBP: 149.04
```

---
