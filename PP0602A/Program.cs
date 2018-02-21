using System;
//Wczytaj ciąg liczb.Następnie wypisz wczytane liczby w taki sposób, 
//aby najpierw pojawiły się te, które wystąpiły na pozycjach parzystych,
//a następnie te, które wystąpiły na pozycjach nieparzystych; 
//z zachowaniem pierwotnej kolejności w obrębie obu grup.Numerujemy od 1.

//Wejście
//Najpierw t - liczba testów. Następnie dla każdego testu liczba 
//n i n liczb, n <= 100.

//Wyjście
//Dla każdego testu n liczb w opisanym porządku.

//Przykład
//Wejście:
//2 
//4 1 2 3 5
//3 9 8 7 


//Wyjście:
//2 5 1 3
//8 9 7
namespace PP0602A
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile, n;
            int b, c, d, e;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] z = Console.ReadLine().Split(' ');
                n = Convert.ToInt32(z[0]);
                if (n == 4)
                {
                    b = Convert.ToInt32(z[1]);
                    c = Convert.ToInt32(z[2]);
                    d = Convert.ToInt32(z[3]);
                    e = Convert.ToInt32(z[4]);
                }
                else if (n == 3)
                {
                    b = Convert.ToInt32(z[1]);
                    c = Convert.ToInt32(z[2]);
                    d = Convert.ToInt32(z[3]);
                }
                string p = "";
                string np = "";
                for (int j = 1; j < n + 1; j++)
                {
                    if (j % 2 == 0)
                    {
                        p += z[j] + " ";
                    }
                    else if (j % 2 != 0)
                    {
                        np += z[j] + " ";
                    }
                }
                Console.WriteLine(p + np);
            }
            Console.ReadKey();
        }
    }
}
