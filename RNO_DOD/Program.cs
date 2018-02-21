using System;
//Twoim zadaniem jest dodać wszystkie liczby całkowite podane na wejściu.

//Wejście
//W pierwszym wierszu znajduje się liczba t testów (0 < t< 100) 
//Każdy test opisany jest w następujący sposób.W pierwszym 
//wierszu dana jest liczba n - liczba liczb do zsumowania.
//Następnie podanych jest n liczb pooddzielanych spacją.

//Przykład
//Input:
//2
//5
//1 2 3 4 5
//2
//-100 100

//Output:
//15
//0
namespace RNO_DOD
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
                string[] z = Console.ReadLine().Split(' ');
                for (int j = 0; j < z.Length; j++)
                {
                    tmp += Convert.ToInt32(z[j]);
                }
                Console.WriteLine(tmp);
                tmp = 0;
            }

            Console.ReadKey();
        }
    }
}
