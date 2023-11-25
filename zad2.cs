/*using System;

class Program
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("Podaj nieujemna liczbe n (n <= 10): ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 10);

        int[,] A = WczytajTablice("Podaj elementy tablicy A:", n);
        int[,] B = WczytajTablice("Podaj elementy tablicy B:", n);

        int[,] C = DodajTablice(A, B, n);

        WyswietlTablice("Tablica C:", C, n);
    }

    static int[,] WczytajTablice(string komunikat, int n)
    {
        Console.WriteLine(komunikat);

        int[,] tablica = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out tablica[i, j]))
                {
                    Console.WriteLine("Wprowadz liczbe calkowita");
                    Console.Write($"Element [{i},{j}]: ");
                }
            }
        }

        return tablica;
    }

    static int[,] DodajTablice(int[,] A, int[,] B, int n)
    {
        int[,] C = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }

        return C;
    }

    static void WyswietlTablice(string komunikat, int[,] tablica, int n)
    {
        Console.WriteLine(komunikat);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{tablica[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}*/