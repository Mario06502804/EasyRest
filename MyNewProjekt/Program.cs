using MyNewProject;

bool Start = true;
while (Start)
{
 Console.Clear();
 Console.WriteLine("Willkommen in RestWork !!\n");
 Console.WriteLine("Bestellung Aufnehmen (1)");
 Console.WriteLine("Tisch Anzeigen       (2)");
 Console.WriteLine("Beenden              (0)");
 Console.Write("\nAuswahl:");
 
 string? eingabe = Console.ReadLine();

 switch(eingabe)
 {
    case "1":
    Console.WriteLine("Tischnummer:");
        if (int.TryParse(Console.ReadLine(),out int TischNr)) // (out int speichert die eingabe in TischNr)
         {
            
            Console.Write("PLU (Artikelnummer): ");
            int plu = int.Parse(Console.ReadLine());

            Console.Write("Artikel Name: ");
            string name = Console.ReadLine();

            Console.Write("Preis (in Euro): ");
            decimal preis = decimal.Parse(Console.ReadLine());
         }
    break;
    case "2":
    System.Console.WriteLine("Tisch Anzeigen");
        if (int.TryParse(Console.ReadLine(), out int TischAnzeigen))
        {
            
        }
    break;
    case "0":
    Start = false;
    break;
 }
}