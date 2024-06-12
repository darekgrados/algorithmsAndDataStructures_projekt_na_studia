using MathNet.Numerics;

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
            Console.WriteLine("Podaj limit, do którego chcesz znaleźć liczby pierwsze:");
            int limit = Convert.ToInt32(Console.ReadLine());

            bool[] sito = new bool[limit + 1];

            for (int i = 2; i <= limit; i++)
            {
                sito[i] = true;
            }

            for (int p = 2; p * p <= limit; p++)
            {
                if (sito[p])
                {
                    for (int i = p * p; i <= limit; i += p)
                    {
                        sito[i] = false;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze mniejsze lub równe " + limit + ":");
            for (int i = 2; i <= limit; i++)
            {
                if (sito[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void RozwiazWielomian5Stopnia()
        {
            Console.WriteLine("Podaj współczynniki wielomianu 5 stopnia (ax^5 + bx^4 + cx^3 + dx^2 + ex + f = 0):");

            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj d: ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj e: ");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj f: ");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rozwiązywanie wielomianu...");

            // Tworzenie tablicy współczynników
            double[] coefficients = { f, e, d, c, b, a };

            // Znajdowanie pierwiastków
            var roots = FindRoots.Polynomial(coefficients);

            Console.WriteLine("Pierwiastki wielomianu:");
            foreach (var root in roots)
            {
                Console.WriteLine(root);
            }
        }

        static void AlgorytmMonteCarlo()
        {
            Console.WriteLine("Podaj liczbę iteracji do oszacowania wartości pi:");
            int iterations = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int insideCircle = 0;

            for (int i = 0; i < iterations; i++)
            {
                double x = rand.NextDouble() * 2 - 1;
                double y = rand.NextDouble() * 2 - 1;

                if (x * x + y * y <= 1)
                {
                    insideCircle++;
                }
            }

            double piEstimate = 4.0 * insideCircle / iterations;
            Console.WriteLine("Oszacowana wartość pi: " + piEstimate);
        }

        static void ProblemKomiwojazera()
        {
            Console.WriteLine("Wybrano problem komiwojażera dla 100 miast.");
            // Implementacja problemu komiwojażera dla 100 miast
        }
    }
}
