using System;
//Sprawdź, czy podane 3 punkty są współliniowe, czy też nie.

//Input
//Najpierw zostaje podana liczba t(1 < t ≤ 100) wykonywanych testów.
//W każdej następnej linii podawane są współrzędne trzech punktów 
//będącymi liczbami całkowitymi z przedziału[-1000, 1000].
//Kolejne współrzędne oddzielone są znakiem tabulacji.


//Output
//Jako wydruk otrzymujemy słowo TAK, gdy podane trzy punkty są 
//współliniowe albo słowo NIE, gdy nie są współliniowe. 
//Każda odpowiedź zapisywana jest w osobnej linii.

//Example
//Input:
//5
//1	2	3	4	5	6
//1	3	1	4	1	-3
//1	2	-3	4	3	9
//2	-1	3	-1	-4	-1
//0	0	0	0	0 	0


//Output:
//TAK
//TAK
//NIE
//TAK
//TAK
namespace JWSPLIN
{
    class Program
    {
        static void Main(string[] args)
        {

            int ile;
            int x1, y1, x2, y2, x3, y3;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] a = Console.ReadLine().Split('	');
                x1 = Convert.ToInt32(a[0]);
                y1 = Convert.ToInt32(a[1]);
                x2 = Convert.ToInt32(a[2]);
                y2 = Convert.ToInt32(a[3]);
                x3 = Convert.ToInt32(a[4]);
                y3 = Convert.ToInt32(a[5]);
                int det = (y2 - y1) * (x3 - x1) - (x2 - x1) * (y3 - y1);
                if (det == 0)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }
            Console.ReadKey();
        }
    }
}
