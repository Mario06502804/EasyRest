namespace MyNewProject
{
    public class Bestellung
    {
        public DateTime Zeitpunkt { get; set; } // quelle von chatgpt DateTime.Now
        public List<Artikel> ArtikelListe { get; set; }

        public Bestellung()
        {
            Zeitpunkt = DateTime.Now;
            ArtikelListe = new List<Artikel>();
        }


        public void ArtikelHinzufuegen(Artikel artikel) // Artikel zur Bestellung hinzufügen
        {
            ArtikelListe.Add(artikel);
        }


        public decimal Gesamtpreis() // Gesamtsumme der Bestellung berechnen
        {
            return ArtikelListe.Sum(a => a.Preis);
        }

        // Textausgabe der Bestellung
        public override string ToString()
        {
            string result = $"Bestellung vom {Zeitpunkt}:\n"; // Initialisiert eine Zeichenkette mit dem Zeitpunkt der Bestellung

            foreach (var artikel in ArtikelListe) // Iteriert über die Liste der Artikel und fügt jeden Artikel der Zeichenkette hinzu
            {
                result += $"\n{artikel}\n";
            }

            result += $"\nSumme: {Gesamtpreis():C}\n"; // Fügt den Gesamtpreis der Bestellung der Zeichenkette hinzu

            return result; // Gibt die resultierende Zeichenkette zurück
        }
        public void ZeigeBestellung()
        {
            Console.WriteLine(ToString());
        }
    }
}


