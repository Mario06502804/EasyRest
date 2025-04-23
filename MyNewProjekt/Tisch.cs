namespace MyNewProject
{
    public class Tisch
    {
        public int Nummer { get; set; } // Tischnummer
        public List<Bestellung> Bestellungen { get; set; } // Liste der Bestellungen für diesen Tisch

        public Tisch(int nummer)
        {
            Nummer = nummer;
            Bestellungen = new List<Bestellung>();
        }

        public void FuegeBestellungHinzu(Bestellung bestellung) // Bestellung zu einem Tisch hinzufügen
        {
            Bestellungen.Add(bestellung);
        }

        public override string ToString() // Textausgabe der Bestellungen für diesen Tisch
        {
            string result = $"Tisch {Nummer}:\n";
            foreach (var bestellung in Bestellungen)
            {
                result += bestellung.ToString() + "\n";
            }
            return result;
        }
    }
}
