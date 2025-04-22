namespace MyNewProject
{
    public class Bestellung
    {
        public int TischNummer { get; set; }
        public List<Artikel> ArtikelListe { get; set; } = new List<Artikel>();
        
    }
}
