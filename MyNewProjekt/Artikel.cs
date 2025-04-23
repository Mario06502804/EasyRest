namespace MyNewProject
{
    public class Artikel
    {
        public string Plu { get; }
        public string Name { get; }
        public decimal Preis { get; }

        public Artikel(string plu, string name, decimal preis) // Konstruktor
        {
            Plu = plu;
            Name = name;
            Preis = preis;
        }

        public override string ToString()  // Ausgabe der Artikelinformationen (Quelle chatGPT)
        {
            return $"(PLU: {Plu})\nName: {Name}\nPreis: {Preis:C}";
        }
    }
}

