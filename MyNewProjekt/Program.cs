using MyNewProject;
Console.OutputEncoding = System.Text.Encoding.UTF8; // damit zeigt es den Euro zeichen an $$$ (KI)

//Hauptmenü Schleife
bool Start = true;// Startvariable für das Hauptmenü auf war
while (Start) // Hauptmenü wiederholen bis der Benutzer "0" eingibt
{
    //Menü Anzeige
    Console.Clear();
    Console.BackgroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("'Kellner Modus' -- Willkommen in EasyRest !!");
    Console.ResetColor();
    Console.WriteLine("\n");
    Console.WriteLine("Bestellung Aufnehmen (1)");
    Console.WriteLine("Tisch Anzeigen       (2)");
    Console.WriteLine("Beenden              (0)");
    Console.WriteLine();
    Console.Write("Auswahl: ");

    string? eingabe = Console.ReadLine();

    switch (eingabe)
    {
        case "1": // bestellung aufnehmen
            Console.Write("Tischnummer: ");

            if (int.TryParse(Console.ReadLine(), out int tischNr))
            {
                Bestellung bestellung;
                // Bestehende Bestellung laden oder neue anlegen
                if (Verwaltung.HatBestellung(tischNr))
                {
                    bestellung = Verwaltung.HoleBestellung(tischNr);
                }
                else
                {
                    bestellung = new Bestellung();
                }
                bool weitereArtikel = true;

                // Schleife für weitere Artikel
                while (weitereArtikel)
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

        case "2":// Tisch anzeigen (Ausgabe)  

            Console.WriteLine("Tisch Anzeigen");
            Console.Write("Tischnummer: ");

            if (int.TryParse(Console.ReadLine(), out int tischAnzeigen)) // eingabe als ganzzahl parsen 
            {
                Verwaltung.ZeigeBestellungen(tischAnzeigen);// wenn parsen erfolreich ist kommt die methode ZeigeBestellung
            }
            Console.ReadLine(); // eingabe befor das programm endet (ENTER)
            break;

        case "0": // programm beenden 
            Start = false;
            break;
    }
}