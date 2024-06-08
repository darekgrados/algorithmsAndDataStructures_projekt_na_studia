namespace algorithmsAndDataStructures
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Wybierz co chcesz zrobić:");
            Console.WriteLine("1 - wielomian 3 stopnia");
            Console.WriteLine("2 - sito Eratostenesa");
            Console.WriteLine("3 - wielomian 5 stopnia");
            Console.WriteLine("4 - algorytm Monte Carlo");
            Console.WriteLine("5 - problem komiwojażera dla 100 miast");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    RozwiazWielomian3Stopnia();
                    break;
                case "2":
                    SitoEratostenesa();
                    break;
                case "3":
                    RozwiazWielomian5Stopnia();
                    break;
                case "4":
                    AlgorytmMonteCarlo();
                    break;
                case "5":
                    ProblemKomiwojazera();
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór, spróbuj ponownie.");
                    break;
            }
        }

        static void RozwiazWielomian3Stopnia()
        {
            Console.WriteLine("Wybrano wielomian 3 stopnia.");
            // Implementacja wielomianu 3 stopnia
        }

        static void SitoEratostenesa()
        {
            Console.WriteLine("Wybrano sito Eratostenesa.");
            // Implementacja sita Eratostenesa
        }

        static void RozwiazWielomian5Stopnia()
        {
            Console.WriteLine("Wybrano rozwiązanie wielomianu 5 stopnia.");
            // Implementacja rozwiązywania wielomianu 5 stopnia
        }

        static void AlgorytmMonteCarlo()
        {
            Console.WriteLine("Wybrano algorytm Monte Carlo.");
            // Implementacja algorytmu Monte Carlo
        }

        static void ProblemKomiwojazera()
        {
            Console.WriteLine("Wybrano problem komiwojażera dla 100 miast.");
            // Implementacja problemu komiwojażera dla 100 miast
        }
    }
}
