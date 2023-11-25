//zad3

/*using System;
class Program
{
    static void Main()
    {
        int n;
        Console.Write("Podaj liczbe naturalna n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Nie jest to liczba naturalna.");
            Console.Write("Podaj liczbe naturalna n: ");
        }

        int[] liczby = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj liczbe {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out liczby[i]) || liczby[i] < 0)
            {
                Console.WriteLine("Nie jest to liczba naturlna. ");
                Console.Write($"Podaj liczbe {i + 1}: ");
            }
        }

        int liczbyParzyste = 0;
        int liczbyNieparzyste = 0;

        foreach (var liczba in liczby)
        {
            if (liczba % 2 == 0)
                liczbyParzyste++;
            else
                liczbyNieparzyste++;
        }

        Console.WriteLine($"Liczby parzyste: {liczbyParzyste}");
        Console.WriteLine($"Liczby nieparzyste: {liczbyNieparzyste}");
    }


}*/