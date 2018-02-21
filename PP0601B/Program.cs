using System;
//Wypisz wszystkie liczby ai podzielne przez x i niepodzielne przez y, 
//gdzie 1 < ai<n< 100000.

//Wejście
//Najpierw w oddzielnej linii t liczba przypadków testowych następnie w
//kolejnych t liniach liczby n x y.

//Wyjście
//W kolejnych t liniach oddzielone pojedynczym odstępem liczby spełniające
//warunki zadania wypisane od najmniejszej do największej.

//Przykład
//Wejście:
//2 
//7 2 4
//35 5 12
//Wyjście:
//2 6 
//5 10 15 20 25 30
namespace PP0601B
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int n, x, y;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                n = Convert.ToInt32(a[0]);
                x = Convert.ToInt32(a[1]);
                y = Convert.ToInt32(a[2]);
                for (int j = 1; j < n; j++)
                {
                    if (j % x == 0 && j % y != 0)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
