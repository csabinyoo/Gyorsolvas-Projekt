# Gyorsolvasó

Olvassa el az alábbi cikket, hogyan működik egy érdekes gyorsolvasó technika, és a leírás alapján próbálja ki működés közben:
- [Gyorsolvasó](https://hvg.hu/tudomany/20140322_gyorsolvasas_chrome_spreed)
- [Gyorsolvasó Chrome bővítmény](https://chromewebstore.google.com/detail/swiftread-read-faster-lea/ipikiaejjblmdopojhpejjmbedhlibno)

## A feladat
1. A program két paramétert kap:
    - A szövegfájlt, amit el  kell olvasni, és
    - Az olvasási sebességet: hány szó/perc (angolul: wpm Word Per Minutes). Ez tipikusan 200...300 körüli érték.

2. A program a konzolon próbálja meg minél jobban utánozni az alkalmazást.
    - Először próbálja úgy, hogy szavanként kirakja a szöveget a képernyő közepére.
    - Fejlessze tovább, hogy a szó előtti és utáni szó is megjelenik, de a szó ki van emelve.
    - Próbálja meg a már elolvasott részt felül, a még el nem olvasott részt alul megfelelő távolságra folymatosan frissítve megjeleníteni.
    - Esetleg legyen lehetőség adott billentyűvel megállítani az olvasást.

## Javaslatok
A feldat megoldásához az alábbi problémákat kell (többek között) megoldania:
Hogyan lehet:
- Lekérdezni a konzol ablak szélességét, magasságát (hány karakter széles, illetve magas)
- Hogy lehet letörölni a konzol tartalmát
- Melyik utasítással lehet adott idejű várakozást kiváltani.
- Milyen módon lehet egy karakter vagy szöveg elé megadott mennyiségű karaktert beszúrni.

Ezen ismeretek alapján már megoldható hogy egy szöveg mindig a konzol közepén jelenjen meg.
Ebben segít az alábbi ábra, ahol a méreteket (ablakSzélesség, szóSzélesség) karkterszámban kell érteni. pl. tükörfúrógép szóSzélesség: 12 (karakter)

![](kep1.png)

## Minta program
- A források között mellékeltünk egy kezdetleges futtatható mintaprogramot forráskód nélkül (`gyorsolvaso.exe`) és egy hozzá tartozó szöveget (`szoveg.txt`). 
- Első körben valami ilyesmit képzeltünk el.
- Indítás prancssorból. (parancsablak indítás: intéző címsorába beír: `cmd` és enter):
```
gyorsolvaso szoveg.txt 200
```

