namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inizializzazione dell'array con i cibi preferiti
            string[] cibiPreferiti = { "Pizza", "Scamorza", "Gelato", "Hamburger di tacchino", "Sushi", "Zuppa di zucca", "Pasta", "Fagioli" };

            // Lunghezza della classifica
            Console.WriteLine("Lunghezza della classifica dei miei cibi preferiti: " + cibiPreferiti.Length);

            // Classifica in ordine dei cibi preferiti
            Console.WriteLine("I miei cibi preferiti in ordine di importanza:");
            for (int i = 0; i < cibiPreferiti.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + cibiPreferiti[i]);
            }

        }
    }
}
