using System;
//Problem Collatza
//Dany jest ciąg xn określony rekurencyjnie:
//x0=s, 
//xn+1=3* xn+1, jeśli xn jest nieparzyste i
//xn+1=xn/2, jeśli xn jest parzyste

//Napisz program, który oblicza pierwsze takie n, dla którego xn = 1.

//Wejście


//W pierwszej linii liczba testów t.W każdym z t kolejnych wierszy
//jedna liczba całkowita s, 1 <= s <= 10000.

//Wyjście
//W każdej linii jedna liczba - obliczona wartość n.

//Przykład
//Wejście:
//5
//1 
//2
//8
//3
//567
//Wyjście:
//0
//1
//3
//7
//61
namespace PTCLTZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile, n;
            int tmp = 0;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                while (n != 1)
                {
                    n = (n % 2 == 0) ? n / 2 : (3 * n) + 1;
                    tmp++;
                }
                Console.WriteLine(tmp);
                tmp = 0;
            }
            Console.ReadKey();
        }
    }
}
