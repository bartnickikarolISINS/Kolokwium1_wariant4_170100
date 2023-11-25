//zad4
/*using System;
class Program
{
    static void Main()
    {
        int[,] macierzA = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] macierzB = { { 7, 8, 9 }, { 10, 11, 12 } };

        int[,] macierzWynikowa = DodawanieMacierzy(macierzA, macierzB);

        Console.WriteLine("Macierz A:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{macierzA[i, j],4} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Macierz B:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{macierzB[i, j],4} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Macierz wynikowa po dodaniu macierzy A i B:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{macierzWynikowa[i, j],4} ");
            }
            Console.WriteLine();
        }

    }

    static int[,] DodawanieMacierzy(int[,] macierzA, int[,] macierzB)
    {
        int[,] macierzWynikowa = new int[2, 3];

        for (int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                macierzWynikowa[i, j] = macierzA[i, j] + macierzB[i, j];
            }
        }

        return macierzWynikowa;
    }

}*/