namespace MyNewProject
{
    public class Artikel
    {
        public int Plu { get; set; } // Artikelnummer
        public string Name { get; set; } // Artikelname
        public decimal Preis { get; set; } // Preis in Euro

        public Artikel(int plu, string name, decimal preis) // Konstruktor für die artikel
        {
            Plu = plu;
            Name = name;
            Preis = preis;
        }

        public override string ToString()  // Ausgabe der Artikelinformationen (Quelle chatGPT)
        {
            return $"PLU: {Plu}, Name: {Name}, Preis: {Preis:C}";
        }
    }
}

