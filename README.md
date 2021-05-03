# O09CTQ_PreWrite

# A program működésének leírása:

A program megkapja a Libary.xml fájlt amiből a szerializáció után programunk dolgozni fog. Az xml tartalmaz könyveket (cím, író és darabszámot) és a cím alapján fog a program generálni .txt fájlokat. Ha az xml megváltozik a program újraindítás után törli a régit és létrehozza az új fájlt.Ezenkívűl van olyan függvény a programban amivel kereshetünk adott fájl névre és egy bool értékkel fog visszatérni és van olyan függvény is amivel a fájl nevét tudjuk megváltoztatni, úgy hogy a tartalmát megőrizzük.
<br><br><br>
IComparer segítségével egy Compare metódussal a Book elemeket csökkenő sorrendbe tudjuk rendezni.
<br><br><br>
A Book osztályban pedig a  + karakteren operator overloading-ot hajtottam végre olyan formába, hogy ha megkap 2 könyvet (például: Book1 + Book2) akkor azt a könyvet fogja nekünk vissza adni amelyiknek a darabszáma több.
<br><br><br>
A program 3 osztály tesztet tartalmaz. A BookTest az operator overloading helyességét vizsgálja meg. A ComparerTest a Compare funkciót vizsgálja meg. A FileManagerTest pedig megvizsgálja, hogy hibás fájl nevére hivatkozva az ExistingItem metódus jól működik-e. 
<br><br><br>
A release verzió megtalálható egy Release.zip fájlba

