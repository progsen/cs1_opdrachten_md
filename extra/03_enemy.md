## Enemy



## coderen

- Gebruik classes & variables om een enemy voor een tower defense spel te maken
- Bedenk wat voor `eigenschappen` een enemy moet hebben om het spel te laten werken en zet deze als `class variables` in de Enemy
- De enemy moet minimaal een health property hebben


## functions
De enemy moet natuurlijk wel damage kunnen krijgen, hiervoor heb je functions & arguments nodig

- Maak een `function` waar je een getal (`int`) aan schade mee kan geven in de class van enemy
- in de `function` haal je het getal van de `health` (`class variable`) af


## Gebruiken

In de Main methode:
- Maak 1 enemy aan met het keyword new, met 100 health
- Maak daaronder een loop met een `while` statement
- De loop houdt op als de enemy 0 of minder health heeft 
- In de loop gebruik je Console.ReadLine() om te wachten
- Daarna doe je de enemy 10 schade
- Schrijf met Console.WriteLine() de overgebleven health van de enemy naar de console

- Aan het eind van het programma zet je nog een Console.ReadLine() om het programma te laten wachten als het klaar is


## challange!

- De damage function met een int als argument ga je vervangen door een Skill (class)
- Maak de Skill class:
- De skill heeft:
1. een naam, in dit geval Basic attack
2. Damage
3. Stamina cost 
4. Cooldown tijd

- geef je Enemy `class` een variable `stamina`
- Maak een `function` in Skill om deze te gebruiken op een andere Enemy (`argument`)
- Dit mag alleen als de cooldown voorbij is
- Dit mag alleen als de enemy genoeg stamina heeft


## git

commit naar je git repository voor de vak!