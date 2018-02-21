using System;
//Odwróć kolejność elementów w tablicy.

//Wejście
//Najpierw liczba testów t(t ≤ 100). Następnie dla każdego testu 
//liczba n(n ≤ 100) i n liczb oddzielonych spacjami.

//Wyjście
//Dla każdego testu n liczb w porządku odwrotnym niż na wejściu.

//Przykład
//Wejście:
//2
//7 1 2 3 4 5 6 7
//3 3 2 11


//Wyjście:
//7 6 5 4 3 2 1
//11 2 3
namespace PP0502B
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile, n;
            string tmp = "";
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                n = Convert.ToInt32(z[0]);
                for (int j = n; j > 0; j--)
                {
                    tmp += z[j] + " ";
                }
                Console.WriteLine(tmp);
                tmp = "";
            }
            Console.ReadKey();
        }
    }
}
