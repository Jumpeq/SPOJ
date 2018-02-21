using System;
//Przesuń elementy tablicy cyklicznie w lewo.

//Wejście
//Najpierw liczba testów t (t ≤ 100). Następnie dla każdego testu 
//liczba n(1 < n ≤ 100) i n liczb.

//Wyjście
//Dla każdego testu n liczb w zmienionym porządku.

//Przykład
//Wejście:
//2
//7 1 2 3 4 5 6 7 
//3 2 1 10

//Wyjście:
//2 3 4 5 6 7 1 
//1 10 2
namespace PTROL
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int n1;
            int ost = 0;
            string tmp = "";
            string wynik = "";
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                n1 = Convert.ToInt32(z[0]);
                for (int j = 1; j < z.Length; j++)
                {
                    ost++;
                }
                tmp = z[1];
                for (int jj = 2; jj < z.Length; jj++)
                {
                    wynik += z[jj] + " ";
                }
                Console.WriteLine(wynik + tmp);
                tmp = "";
                wynik = "";

            }
            Console.ReadKey();
        }
    }
}
