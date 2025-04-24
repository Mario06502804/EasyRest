using MyNewProject;
Console.OutputEncoding = System.Text.Encoding.UTF8; // damit zeigt es den Euro zeichen an $$$

bool Start = true;// Startvariable für das Hauptmenü
while (Start) // Hauptmenü wiederholen bis der Benutzer "0" eingibt
{
    Console.Clear();

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("'Kellner Modus' -- Willkommen in EasyRest !!");
    Console.ResetColor();
    Console.WriteLine("\n");
    Console.WriteLine("Bestellung Aufnehmen (1)");
    Console.WriteLine("Tisch Anzeigen       (2)");
    Console.WriteLine("Beenden              (0)");
    Console.Write("\nAuswahl: ");

    string? eingabe = Console.ReadLine();

    switch (eingabe)
    {
        case "1": // mit case 1 - bestellung aufnehmen
            Console.Write("Tischnummer: ");

            if (int.TryParse(Console.ReadLine(), out int tischNr))
            {
                Bestellung bestellung;
                if (Verwaltung.HatBestellung(tischNr))
                {
                    bestellung = Verwaltung.HoleBestellung(tischNr); // alte Bestellung holen
                }
                else
                {
                    bestellung = new Bestellung(); // neue anlegen
                }
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
                                Name = gesucht[1];
                                Preis = decimal.Parse(gesucht[gesucht.Length - 2]);
                                Artikel artikel = new(plu, Name, Preis); // Artikel erstellen und zur Bestellung hinzufügen
                                bestellung.ArtikelHinzufuegen(artikel);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nArtikel wurde zur Bestellung hinzugefügt.");
                                Console.ResetColor();
                                break;// Wenn der Artikel gefunden wird, wird die Schleife abgebrochen
                            }
                        }
                    }
                    Console.Write("\nWeiteren Artikel hinzufügen? (j/n): ");
                    string? weiter = Console.ReadLine();

                    if (weiter?.ToLower() != "j") weitereArtikel = false;
                }
                Verwaltung.FuegeBestellungHinzu(tischNr, bestellung);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bestellung wurde gespeichert!");
                Console.ResetColor();
                Console.WriteLine("Drücke Enter, um zum Hauptmenü zurückzukehren...");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ungültige Tischnummer.");
                Console.ResetColor();
                Console.ReadKey();
            }
            break;

        case "2":// mit case 2 tisch anzeigen (Ausgabe)  

            Console.WriteLine("Tisch Anzeigen");
            Console.Write("Tischnummer: ");

            if (int.TryParse(Console.ReadLine(), out int tischAnzeigen)) // eingabe als ganzzahl parsen 
            {
                Verwaltung.ZeigeBestellungen(tischAnzeigen);// wenn parsen erfolreich ist kommt die methode ZeigeBestellung
            }
            Console.ReadLine(); // eigabe befor das programm endet
            break;

        case "0": // programm beenden 
            Start = false;
            break;
    }
}