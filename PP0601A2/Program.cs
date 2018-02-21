using System;
//Przepisz dane z wejścia na wyjście.Dane wejściowe są dwucyfrowymi
//liczbami naturalnymi.Zakończ działanie programu, gdy na wejściu
//pojawi się, trzecia liczba 42 poprzedzona jakąkolwiek inną liczbą, 
//różną od 42.

//Wejście
//W każdej linii jedna liczba dwucyfrowa.

//Wyjście
//W każdej linii jedna liczba dwucyfrowa.Odczytane wartości 42 również 
//powinny się pojawić.

//Przykład
//Wejście:
//42
//42
//12
//13
//42
//11
//42
//43
//42
//42
//99
//01
//Wyjście:
//42
//42
//12
//13
//42
//11
//42
//43
//42

namespace PP0601A2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, zm = 0;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (zm == 3) break;
                else
                {
                    if ((x == 42) && (y != x) && (y != 0))
                    {
                        zm++;
                        y = x;
                    }
                    else y = x;
                }
                Console.WriteLine(x);
            } while (0 == 0);
        }
    }
}
