Scenár
Rozhodol som sa vytvoriť rezervačný systém pre reštauráciu. Tento systém bude slúžiť nielen na rezerváciu miesta v reštaurácii ale aj na online objednávku z menu. V systéme bude taktiež administrátorské rozhranie, cez ktoré bude možné za prihlásiť a následne pridávať a odoberať jedlá z ponuky.

Požiadavky na projekt
•	Databáza obsahujúca 4 tabuľky. Tabuľka č.1 bude slúžiť na ukladanie informácií o danom jedle (fotka, názov, cena). Tabuľka č.2 bude slúžiť na ukladanie informácií o rezerváciách (meno, telefón, čas rezervácie). Tabuľka č.3  bude slúžiť na ukladanie informácií o objednávke (meno, priezvisko, jedlo, adresa, cena). Tabuľka č.4 bude ukladať prihlasovacie meno a SHA-512 hash hesla.

•	GUI , ktoré bude mať 4 taby. Tab č.1 bude simulovať rozloženie stolov v reštaurácii, kde bude možné vybrať stôl a time slot, na rezerváciu. Tab č.2 bude slúžiť na objednanie jedla z ponuky a následne vyplnenie údajov k dokončeniu objednávky. Tab č.3 bude slúžiť ako administrátorské rozhranie, kde bude nutné prihlásenie obsluhy, ktorá bude môcť manipulovať s ponukou a pridávať/odoberať jedlá. 4. Tab bude slúžiť na napísanie recenzie.

•	V GUI bude možné zobraziť aktuálnu ponuku s jedlami a vytvoriť objednávku. Pre vytvorenie objednávky bude užívateľ musieť zvoliť produkty, ktoré chce a ich počet. Následne bude musieť vyplniť základné údaje o sebe (Meno, Priezvisko, Telefón).

•	Taktiež bude možné rezervovať si stôl na určitý čas, pričom časy sa pri jednom stole nemôžu prekrývať.

Použité technológie
SQL Server Management Studio - databáza
C# - frontend/backend

Časový plán
•	Rozplánovanie aktivít a návrh aplikácie – 2h
•	Vytvorenie databázy, príslušných tabuliek a relácií -3h
•	Naplnenie tabuliek datami – 1h
•	Vytvorenie GUI, s potrebnými tabmi – 4h
•	Spojenie form app s databázou na potrebné transfery dát -4h
•	Tvorba administrátorského rozhrania a funkcionalita prihlasovania. – 2h
•	Funkcionalita slúžiaca na upravovanie menu -7h
•	Funkcionalita slúžiaca na zobrazovanie menu – 3h
•	Funkcionalita na rezervovanie miesta pri danom stole – 11h
•	Testing funkčnosti -3h
