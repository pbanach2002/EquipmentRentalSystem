# Equipment Rental System

## Opis projektu

Aplikacja konsolowa napisana w C#, służąca do obsługi uczelnianej wypożyczalni sprzętu.
System umożliwia dodawanie użytkowników i sprzętu, wypożyczanie, zwroty oraz kontrolę dostępności i limitów wypożyczeń.

---

## Struktura projektu

Projekt został podzielony na główne części:

* **Models** – zawiera klasy reprezentujące dane (np. `Equipment`, `User`, `Rental`)
* **Services** – zawiera logikę biznesową (np. `RentalService`)
* **Program.cs** – pełni rolę prostego interfejsu konsolowego

---

## Uzasadnienie podziału

Zdecydowałem się na taki podział, ponieważ pozwala on oddzielić dane od logiki działania systemu.

* Klasy w folderze **Models** przechowują wyłącznie dane i nie zawierają logiki biznesowej
* Klasa **RentalService** odpowiada za wszystkie operacje systemu, takie jak wypożyczanie, zwroty oraz walidację reguł
* **Program.cs** odpowiada jedynie za uruchomienie scenariusza i komunikację z użytkownikiem

Dzięki temu kod jest bardziej czytelny i łatwiejszy do rozbudowy.

---

## Kohezja (spójność)

Każda klasa ma jedną, jasno określoną odpowiedzialność:

* `Equipment` i jego pochodne – opisują sprzęt
* `User` i jego pochodne – opisują użytkowników
* `Rental` – reprezentuje pojedyncze wypożyczenie
* `RentalService` – zarządza logiką wypożyczeń

Dzięki temu klasy nie mieszają różnych odpowiedzialności.

---

## Coupling (powiązania)

Zależności między klasami zostały ograniczone:

* Modele nie znają logiki systemu
* Logika znajduje się w jednym miejscu (`RentalService`)
* `Program.cs` korzysta tylko z publicznych metod serwisu

Dzięki temu zmiany w jednej części systemu mają minimalny wpływ na inne.

---

## Decyzje projektowe

* Zastosowano dziedziczenie (`Equipment`, `User`) w celu współdzielenia wspólnych cech
*  Logika biznesowa została wydzielona do klasy RentalService.
  Program.cs nie zawiera żadnych reguł ani decyzji – jedynie wywołuje metody serwisu.
* Wszystkie operacje, takie jak sprawdzanie dostępności sprzętu, kontrola limitów użytkownika
czy obsługa zwrotów, są realizowane w jednej klasie serwisowej.
* Dzięki temu logika systemu jest skupiona w jednym miejscu, co ułatwia jej utrzymanie i rozwój. 
* Nie zdecydowano się na dalszy podział na mniejsze klasy serwisowe, ponieważ w obecnym
  zakresie projektu nie przynosiłoby to realnych korzyści, a jedynie zwiększyłoby
  złożoność rozwiązania.
---

## Uruchomienie

Projekt można uruchomić w środowisku JetBrains Rider lub za pomocą polecenia:

```
dotnet run
```
