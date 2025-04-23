
namespace MyNewProject
{
    public static class Verwaltung
    {
        private static Dictionary<int, Tisch> tische = new(); // Dictionary für Tische ChatGPT

        public static void FuegeBestellungHinzu(int tischnummer, Bestellung bestellung) //neuer Tisch anlegen
        {
            if (!tische.ContainsKey(tischnummer))
            {
                tische[tischnummer] = new Tisch(tischnummer);
            }
            tische[tischnummer].FuegeBestellungHinzu(bestellung);
        }

        public static void ZeigeBestellungen(int tischnummer) // Bestellung für einen Tisch anzeigen
        {
            if (tische.ContainsKey(tischnummer))
            {
                Console.WriteLine(tische[tischnummer].ToString());
            }
            else
            {
                Console.WriteLine($"Keine Bestellungen für Tisch {tischnummer} vorhanden.");
            }
        }
    }
}
