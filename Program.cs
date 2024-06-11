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
            Console.WriteLine("Podaj współczynniki wielomianu 3 stopnia (ax^3 + bx^2 + cx + d = 0):");

            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj d: ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rozwiązywanie wielomianu...");

            // Normalizacja współczynników 
            double A = b / a;
            double B = c / a;
            double C = d / a;

            // Obliczanie pośrednich wartości
            double Q = (3.0 * B - Math.Pow(A, 2)) / 9.0;
            double R = (9.0 * A * B - 27.0 * C - 2.0 * Math.Pow(A, 3)) / 54.0;
            double D = Math.Pow(Q, 3) + Math.Pow(R, 2);  // Dyskryminanta

            if (D > 0)  // Jeden pierwiastek rzeczywisty
            {
                double S = CubeRoot(R + Math.Sqrt(D));
                double T = CubeRoot(R - Math.Sqrt(D));

                double x1 = -A / 3.0 + (S + T);
                Console.WriteLine("Pierwiastek rzeczywisty: x = " + x1);
            }
            else if (D == 0)  // Wszystkie pierwiastki rzeczywiste, przynajmniej dwa równe
            {
                double S = CubeRoot(R);
                double x1 = -A / 3.0 + 2.0 * S;
                double x2 = -A / 3.0 - S;

                Console.WriteLine("Pierwiastki rzeczywiste:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else  // Trzy różne pierwiastki rzeczywiste
            {
                double theta = Math.Acos(R / Math.Sqrt(-Math.Pow(Q, 3)));
                double sqrtQ = Math.Sqrt(-Q);

                double x1 = 2.0 * sqrtQ * Math.Cos(theta / 3.0) - A / 3.0;
                double x2 = 2.0 * sqrtQ * Math.Cos((theta + 2.0 * Math.PI) / 3.0) - A / 3.0;
                double x3 = 2.0 * sqrtQ * Math.Cos((theta + 4.0 * Math.PI) / 3.0) - A / 3.0;

                Console.WriteLine("Pierwiastki rzeczywiste:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
                Console.WriteLine("x3 = " + x3);
            }
        }

        static double CubeRoot(double x)
        {
            return Math.Pow(x, 1.0 / 3.0);
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
