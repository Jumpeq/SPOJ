using System;
//Napisz funkcję:

// int nwd(int a, int b);
//która oblicza największy wspólny dzielnik liczb a i b,

// 0 <= a,b <= 1000000
//Input


//W pierwszej linii liczba testów t, w kolejnych liniach 
//po dwie liczby w każdym wierszu.

//Output
//W każdej linii jedna liczba - wynik działania funkcji nwd

//Example
//Input:
//5
//1 4
//4 1
//12 48
//48 100
//123456 653421

//Output:
//1
//1
//12
//4
//3
namespace PP0501A
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int a, b;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                a = Convert.ToInt32(z[0]);
                b = Convert.ToInt32(z[1]);
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                Console.WriteLine(a);

            }
            Console.ReadKey();
        }
    }
}
