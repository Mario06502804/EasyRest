namespace MyNewProject
{
    public class Tisch
    {
        public int Nummer { get; set; } // Tischnummer
        public List<Bestellung> Bestellungen { get; set; } // Liste der Bestellungen für diesen Tisch

        public Tisch(int nummer) //Konstruktor der die Tischnummer initialisiert
        {
            Nummer = nummer;
            Bestellungen = new List<Bestellung>();
        }

        public void FuegeBestellungHinzu(Bestellung bestellung) // Bestellung zu einem Tisch hinzufügen
        {
            Bestellungen.Add(bestellung); // add a objekt zu der Liste
        }

        public override string ToString() // Überschreibt die ToString-Methode, um die Bestelldetails anzuzeigen
        {
            string result = $"Tisch {Nummer}:\n"; // Initialisiert eine Zeichenkette mit der Tischnummer
            foreach (var bestellung in Bestellungen) // Iteriert über die Liste der Bestellungen 
            {                                        // und fügt jede Bestellung der Zeichenkette hinzu
                result += bestellung.ToString() + "\n";
            }
            return result; // Gibt die resultierende Zeichenkette zurück
        }
    }
}
