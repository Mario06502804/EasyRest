using MyNewProject;

bool Start = true;
while (Start) // Hauptmenü wiederholen bis der Benutzer "0" eingibt
{
    Console.Clear();
    Console.WriteLine("'Kellner Modus'");
    Console.WriteLine("Willkommen in RestWork !!\n");
    Console.WriteLine("Bestellung Aufnehmen (1)");
    Console.WriteLine("Tisch Anzeigen       (2)");
    Console.WriteLine("Beenden              (0)");
    Console.Write("\nAuswahl:");

    string? eingabe = Console.ReadLine();

    switch (eingabe)
    {
        case "1": // bestellung aufnehmen
            Console.Write("Tischnummer: ");
            if (int.TryParse(Console.ReadLine(), out int tischNr))
            {
                Bestellung bestellung = new();
                bool weitereArtikel = true;

                while (weitereArtikel)
                {
                    Console.Write("PLU (Artikelnummer): ");

                    if (int.TryParse(Console.ReadLine(), out int plu))
                    {
                        Console.WriteLine("Ungültige PLU.");
                        continue;
                    }

                    Console.Write("Artikel Name: ");
                    string? name = Console.ReadLine();

                    Console.Write("Preis (in Euro): ");

                    if (!decimal.TryParse(Console.ReadLine(), out decimal preis))
                    {
                        Console.WriteLine("Ungültiger Preis.");
                        continue;
                    }

                    Artikel artikel = new(plu, name, preis);
                    bestellung.ArtikelHinzufuegen(artikel);

                    Console.Write("Weiteren Artikel hinzufügen? (j/n): ");
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