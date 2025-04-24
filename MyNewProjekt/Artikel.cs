namespace MyNewProject
{
    public class Artikel
    {
        public string Plu { get; set; }
        public string Name { get; set; }
        public decimal Preis { get; set; }

        public Artikel(string plu, string name, decimal preis) // Konstruktor
        {
            Plu = plu;
            Name = name;
            Preis = preis;
        }

        public override string ToString()  // Ausgabe der Artikelinformationen (Quelle chatGPT)
        {
            return $"Plu: {Plu}\nName: {Name}\nPreis: {Preis:C}";
        }
    }
}

