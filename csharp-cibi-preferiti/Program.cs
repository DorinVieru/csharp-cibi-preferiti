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

            // Il mio cibo top
            Console.WriteLine("Il mio cibio preferito: " + cibiPreferiti[0]);

            // Il mio cibo ultimo in classifica
            Console.WriteLine("Un cibo che mi piace ma non troppo: " + cibiPreferiti[cibiPreferiti.Length - 1]);

            // BONUS: Stampa del cibo a mezza classifica
            if (cibiPreferiti.Length % 2 == 0) // Se il numero di elementi è pari
            {
                int indexMed1 = cibiPreferiti.Length / 2 - 1;
                int indexMed2 = cibiPreferiti.Length / 2;
                Console.WriteLine("I miei cibi di mezza classifica: " + cibiPreferiti[indexMed1] + ", " + cibiPreferiti[indexMed2]);
            }
            else // Se il numero di elementi è dispari
            {
                int indexMed = cibiPreferiti.Length / 2;
                Console.WriteLine("Il mio cibo di mezza classifica: " + cibiPreferiti[indexMed]);
            }
        }
    }
}
