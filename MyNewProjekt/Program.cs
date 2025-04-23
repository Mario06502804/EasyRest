using MyNewProject;
Console.OutputEncoding = System.Text.Encoding.UTF8; // damit zeigt es den Euro zeichen an $$$

bool Start = true;// Startvariable für das Hauptmenü
while (Start) // Hauptmenü wiederholen bis der Benutzer "0" eingibt
{
    Console.Clear();// Bildschirm löschen
    Console.WriteLine("'Kellner Modus' -- Willkommen in RestWork !!");
    Console.WriteLine("\n");
    Console.WriteLine("Bestellung Aufnehmen (1)");
    Console.WriteLine("Tisch Anzeigen       (2)");
    Console.WriteLine("Beenden              (0)");
    Console.Write("\nAuswahl: ");

    string? eingabe = Console.ReadLine();

    switch (eingabe)// Eingabe des Benutzers
    {
        case "1": // bestellung aufnehmen
            Console.Write("Tischnummer: ");

            if (int.TryParse(Console.ReadLine(), out int tischNr))
            {
                Bestellung bestellung = new();
                bool weitereArtikel = true;// Variable für weitere Artikel(neues artikel) 

                while (weitereArtikel)// Schleife für weitere Artikel
                {
                    Console.WriteLine("\nArtikel hinzufügen");
                    Console.WriteLine("Bitte PLU (Artikelnummer) eingeben: ");
                    string plu = Console.ReadLine();
                    string Name = "";
                    decimal Preis = 0;
                    using (StreamReader sr = new StreamReader("C:\\Users\\mario\\source\\repos\\MyNewProjekt\\MyNewProjekt\\ArtikelList.txt"))
                    // Streamreader (quelle Nils & Youtube und hilfe Herr Hafner)
                    {
                        string line;// Variable für die Zeile
                        string[] gesucht;

                        while ((line = sr.ReadLine()) != null)// liest die Datei zeilenweise
                        {
                            gesucht = line.Split(' ');// Artikelnummer und Name trennen von der Liste sowie preis
                            if (plu == gesucht[0])
                            {
                                Console.WriteLine(line);
                                // Artikel erstellen und zur Bestellung hinzufügen
                                Artikel artikel = new(plu, Name, Preis);
                                bestellung.ArtikelHinzufuegen(artikel);
                                Console.WriteLine($"\nArtikel wurde zur Bestellung hinzugefügt.");
                                break;// Wenn der Artikel gefunden wird, wird die Schleife abgebrochen
                            }
                        }
                    }
                    Console.Write("\nWeiteren Artikel hinzufügen? (j/n): ");
                    string? weiter = Console.ReadLine();

                    if (weiter?.ToLower() != "j") weitereArtikel = false;
                }
                Verwaltung.FuegeBestellungHinzu(tischNr, bestellung);
                Console.WriteLine("Bestellung wurde gespeichert!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ungültige Tischnummer.");
                Console.ReadKey();
            }
            break;

        case "2":// tisch anzeigen

            Console.WriteLine("Tisch Anzeigen");
            Console.Write("Tischnummer: ");

            if (int.TryParse(Console.ReadLine(), out int tischAnzeigen))
            {
                Verwaltung.ZeigeBestellungen(tischAnzeigen);
            }
            Console.ReadLine();
            break;

        case "0": // programm beenden 
            Start = false;
            break;
    }
}