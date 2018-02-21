using System;
//Dla podanego ciągu długości 2* k, wypisz na standardowe wyjście dokładnie 
//pierwszą połowę ciągu.

// Wejście
// W pierwszej linijce wejścia znajduje się jedna liczba całkowita 
//t(1<=t<=100). Każdy wiersz o numerze od 2 do t+1, zawiera ciąg 
//długości 2* k(1<=k<=1000).

//Wyjście
//Dla każdego przypadku testowego na wyjściu powinien pojawić się ciąg
//będący pierwszą połową wczytanego ciągu.

//Example
//Wejście:
//3
//pierwszy
//lubiec
//ktotozrobi

//Output:
//pier
//lub
//ktoto
namespace POL
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int n = 0;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string a = Console.ReadLine();
                char[] wyraz = a.ToCharArray();
                for (int j = 0; j < a.Length; j++)
                {
                    n++;
                }
                Console.WriteLine("{0}", a.Substring(0, n / 2));
                n = 0;
            }
            Console.ReadKey();
        }
    }
}
