namespace MyNewProject
{
    public class Bestellung
    {
        public DateTime Zeitpunkt { get; set; }               // Zeitpunkt der Bestellung
        public List<Artikel> ArtikelListe { get; set; }       // Artikel in der Bestellung

        public Bestellung()  // quelle von chatgpt DateTime.Now
        {
            Zeitpunkt = DateTime.Now;
            ArtikelListe = new List<Artikel>();
        }

        // Artikel zur Bestellung hinzufügen
        public void ArtikelHinzufuegen(Artikel artikel)
        {
            ArtikelListe.Add(artikel);
        }

        // Gesamtsumme der Bestellung berechnen
        public decimal Gesamtpreis()
        {
            return ArtikelListe.Sum(a => a.Preis);
        }

        // Textausgabe der Bestellung
        public override string ToString()
        {
            string result = $"Bestellung vom {Zeitpunkt}:\n";
            foreach (var artikel in ArtikelListe)
            {
                result += $"\n * {artikel}\n";
            }
            result += $"\nGesamt: {Gesamtpreis():C}\n";
            return result;
        }
    }
}


