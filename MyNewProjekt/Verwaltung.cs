namespace MyNewProject
{
    public static class Verwaltung
    {
        private static Dictionary<int, Bestellung> bestellungen = new();

        public static void FuegeBestellungHinzu(int tischNr, Bestellung neueBestellung)
        {
            if (bestellungen.ContainsKey(tischNr))
            {
                foreach (var artikel in neueBestellung.ArtikelListe)
                {
                    bestellungen[tischNr].ArtikelHinzufuegen(artikel);
                    break;
                }
            }
            else
            {
                bestellungen[tischNr] = neueBestellung;
            }
        }

        public static bool HatBestellung(int tischNr)
        {
            return bestellungen.ContainsKey(tischNr);
        }

        public static Bestellung HoleBestellung(int tischNr)
        {
            return bestellungen[tischNr];
        }

        public static void ZeigeBestellungen(int tischNr)
        {
            if (bestellungen.TryGetValue(tischNr, out Bestellung bestellung))
            {
                Console.WriteLine($"\nBestellung für Tisch {tischNr}:");
                bestellung.ZeigeBestellung();
                decimal brutto = bestellung.Gesamtpreis();
                decimal netto = brutto / 1.19m;
                decimal mwst = brutto - netto;

                Console.WriteLine($"Netto Betrag:  {netto:C}");
                Console.WriteLine($"MwSt (19%):    {mwst:C}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rechnung:      {brutto:C}");
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine("Keine Bestellung für diesen Tisch gefunden.");
            }
        }
    }
}
