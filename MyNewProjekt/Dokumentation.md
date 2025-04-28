Dokumentation 'EasyRest'

ProjektZiele: 

- schnelle Aufnahme von Artikel über PLU code
- Ansicht von verwendete Tische
- Rechnungsanzeige mit MwSt.
- temporäre Speicherung der Daten wären die Konsole läuft


Tecnologie: 

- C#
- Konsolenanwendung
- Visual Studio 2022
- .NET 9.0


Projektstruktur:

- `Program.cs` – Hauptmenü und Programmablauf
- `Artikel.cs` – Modell für einzelne Artikel
- `Bestellung.cs` – Logik für Bestellungen pro Tisch
- `Tisch.cs` – Modell zur Verwaltung der Tischnummern
- `Verwaltung.cs` – zentrale Verwaltungslogik
- `ArtikelList.txt` – Artikeldatenbank mit PLU, Name und Preis
- `README.md` – Projekt Anleitung
- `Dokumentation.md` – Projektdokumentation



Dokumentation:

das Projekt ist ein einfaches Kellner-Kassensystem, das es ermöglicht, Bestellungen aufzunehmen und Tische Anzeigen.
Es ist als Konsolenanwendung in C# implementiert und bietet eine einfache Benutzeroberfläche zur Interaktion mit dem System.
Die Daten werden temporär während der Programmlaufzeit gespeichert, wenn die Konsole Geschlossen wird werden auch die daten gelöcht.
Die Anwendung verwendet eine Textdatei (`ArtikelList.txt`), um die Artikeldaten zu speichern, einschließlich PLU (Artikelnummer), Name und Preis.

Die Hauptkomponenten des Projekts sind:
	- `Program.cs`: Dies ist die Hauptdatei, die das Programm steuert und das Hauptmenü anzeigt.
					Hier werden die Benutzerinteraktionen verarbeitet und die verschiedenen Funktionen des Systems aufgerufen.
	- `Artikel.cs`: Diese Datei definiert das Modell für einzelne Artikel, einschließlich ihrer Eigenschaften wie PLU, Name und Preis.
	- `Bestellung.cs`: Diese Datei enthält die Logik für Bestellungen pro Tisch, einschließlich der Verwaltung von Bestellungen und der Berechnung von Rechnungen.
	- `Tisch.cs`: Diese Datei definiert das Modell zur Verwaltung der Tischnummern und deren Zuordnung zu Bestellungen.
	- `Verwaltung.cs`: Diese Datei enthält die zentrale Verwaltungslogik für das System.
	- `ArtikelList.txt`: Diese Datei dient als Artikeldatenbank, in der die PLU, der Name und der Preis der Artikel gespeichert sind.

probleme gab mit der Rechnungsanzeige, da ich nicht wusste wie ich die MwSt. berechnen kann und wie ich die Rechnung ausgeben kann.
die anwendung von der Variable StreamReader und StreamWriter war mir nicht bekannt, ich habe es aber geschafft die Daten in eine TXT datei zu schreiben,
und später mit Hilfe von Nils und Herr Hafner habe ich die Variable richtig einsetzen können.
Die Anwendung ist einfach zu bedienen und bietet eine grundlegende Funktionalität für Kellner, um Bestellungen aufzunehmen und Tische Anzuzeigen.

Später konnte ich die Anwendung erweitern, um zusätzliche Funktionen hinzuzufügen, wie z.B. die Möglichkeit, Artikel zu bearbeiten oder zu löschen,
Preisänderungen vorzunehmen, Rabatte anzuwenden und Zahlungsoptionen zu integrieren.
Die Anwendung könnte auch um eine grafische Benutzeroberfläche (GUI) mit WPF oder Windows Forms erweitert werden,
um die Benutzererfahrung zu verbessern.
Die Anwendung könnte auch um eine Mehrsprachigkeit erweitert werden, um sie für internationale Benutzer zugänglicher zu machen.
Die Anwendung könnte auch um Funktionen wie das Splitten oder Wechseln von Tischen, das Aufteilen von Rechnungen und die Ausgabe für die Küche und Theke erweitert werden.
unter anderem...... 


das projekt habe ich mit Hilfe von ChatGPT erstellt, was sehr hilfreich war.
dazu muss man sagen das die KI nicht immer die Besten oder Richtigen antworten gibt.




