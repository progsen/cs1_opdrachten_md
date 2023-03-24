## Time


Maak nieuw `Console project` aan met de naam `CalcExtra`

## circle circle variabelen

We gaan een circle-circle berekening doen


- maak 2 punten aan met variabelen elk een `x & y coordinaat`. type `float`
- noem deze `x1, y1, x2 en y2`
- maak ook nog 2 variabelen aan voor de straal (`rad`)
- noem deze `rad1 en rad2`

- maak ook nog 1 variabele met naam `testLength`
- geef deze de waarde 15
- 
## waardes geven

- punt 1 (x1,y1) heeft coordinaat: (50,50)
- punt 2 (x2,y2) heeft coordinaat: (60,50)
```er zit dus een afstand 10 pixels tussen deze punten```

- geef `rad1` de waarde `5`
- geef `rad2` de waarde `5`
```ze zouden elkaar dus moeten raken!```

## rekenen
- we gaan nu kijken of deze punten elkaar raken met pythagoras https://en.wikipedia.org/wiki/Pythagorean_theorem
- de formule was:  `double length = Math.Sqrt((dx * dx) + (dy * dy));`
- maak een `variabele dx` met als waarde  `x2 min x1` (type float)
- maak een `variabele dy` met als waarde  `y2 min y1` (type float)
- voeg dit aan je code toe: `bool collide = length <= testLength;`

- schrijf de collide bool naar de console, deze zou true moeten geven.

## testLength aanpassen

- geef nu testLength de waarde 5
- nu zou de console false moeten laten zien
## git

commit naar je git repository voor de vak!
