using System;
//Sprawdź, które spośród danych liczb są liczbami pierwszymi

//Input
//n - liczba testów n<100000, w kolejnych liniach n liczb z 
//przedziału[1..10000]

//Output
//Dla każdej liczby słowo TAK, jeśli liczba ta jest pierwsza,
//słowo: NIE, w przeciwnym wypadku.

//Example
//Input:
//3
//11
//1
//4

//Output:
//TAK
//NIE
//NIE
namespace PRIME_T
{
    class Program
    {
        public static string CzyPierwsza(int a)
        {
            if (a < 2) return String.Format("NIE");
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return String.Format("NIE");
            }
            return String.Format("TAK");
        }
        static void Main(string[] args)
        {
            int ile;
            int a;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                a = Convert.ToInt32(z[0]);
                Console.WriteLine(CzyPierwsza(a));
            }
            Console.ReadKey();
        }
    }
}
