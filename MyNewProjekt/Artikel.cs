namespace MyNewProject
{
    public class Artikel
    {
        public string Name { get; set; } // Name eingabe
        public decimal Preis { get; set; } // Preis eingabe
        public Artikel(string name, decimal preis)
        {
            Name = name;
            Preis = preis;
        }
        public override string ToString () => $"{Name} - {Preis:C}"; // chat gpt 

    }
}
