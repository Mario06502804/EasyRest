EasyRest – Kellner-Kassensystem (Konsolen-App in C#)
EasyRest ist ein einfaches Kassensystem für Kellner, bei dem bestellungen aufgenommen werden und Tische verwaltet werden können.

Funktionen

- Aufnahme von Artikeln per PLU (Artikelnummer), Name und Preis
- Zuordnung von Bestellungen zu Tischen
- Anzeige aller Bestellungen für einen bestimmten Tisch
- Rechnungsausgabe inkl. MwSt.
- Temporäre Speicherung während der Programmlaufzeit

Projektstruktur 

- `Program.cs` – Hauptmenü und Programmablauf
- `Artikel.cs` – Modell für einzelne Artikel
- `Bestellung.cs` – Logik für Bestellungen pro Tisch
- `Tisch.cs` – Modell zur Verwaltung der Tischnummern
- `Verwaltung.cs` – zentrale Verwaltungslogik
- `ArtikelList.txt` – Artikeldatenbank mit PLU, Name und Preis
- `README.md` – Projektdokumentation

Mögliche erweiterungen

- gruppierung von gleiche artikel bei Bestellunganzeige 
- Grafische Benutzeroberfläche (Gui) mit WPF ode WindowsForms 
- Speicher möglichkeiten mit JSON oder XML damit beim neu start alle daten vorhanden sind die schon gebucht wurden.
- login für kellner 
- Ein Menü um auf andere Sprachen das program aus zu führen 
- artikel bearbeiten oder löschen
- preis Änderungen oder Rabatte 
- Zahlungs möglichkeiten oder Zimmerbuchungen
- tisch splitten oder wechseln
- Rechnungen aufteilen
- Neue Artikel Hinzufügen (Optional da es einfach über die TXT datei geht)
- Ausgabe für Küche was Speisen sind
- Ausgabe für Theke was Getränke sind 
- Artikel Finktionen (z.b. Ohne zwiebel, mit Eis, Ohne Soße.....)
  
