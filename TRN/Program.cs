using System;
//Transponuj podaną macierz.



//Wejście
//W pierwszym wierszu znajdują się dwie liczby m n(1<=m, n<=200) 
//oznaczające odpowiednio liczbę wierszy oraz liczbę kolumn.
//Następnie następuje m wierszy, w każdym n liczb.

//Wyjście
//Na wyjściu powinna znaleźć się macierz transponowana do zadanej

//Przykład
//Wejście:
//4 3
//1 2 5
//4 3 3
//3 4 9
//8 7 7

//Wyjście:
//1 4 3 8
//2 3 4 7
//5 3 9 7
namespace TRN
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            string[] b = Console.ReadLine().Split(' ');
            m = Convert.ToInt32(b[0]);
            n = Convert.ToInt32(b[1]);
            string[][] matrix = new string[m][];
            for (int r = 0; r < m; r++)
            {
                matrix[r] = Console.ReadLine().Split(' ');
            }
            for (int c = 0; c < n; c++)
            {
                for (int r = 0; r < m; r++)
                    Console.Write("{0} ", matrix[r][c]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
