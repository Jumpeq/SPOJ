using System;
//Równanie liniowe jest postaci ax+b=c, gdzie a, b, c są liczbami 
//rzeczywistymi.Niewiadomą jest x, która również jest liczbą rzeczywistą.
//Równanie to może mieć jedno rozwiązanie, brak rozwiązań lub nieskończenie
//wiele rozwiązań.

//Input
//W pojedyńczej linii podane są trzy liczby rzeczywiste zaokrąglone
//do drugiego miejsca po przecinku.

//Output
//Rozwiązaniem problemu jest liczba rzeczywista zaokrąglona do drugiego 
//miejsca po przecinku w przypadku, gdy równanie liniowe ax+b= c posiada 
//rozwiązanie. W przypadku braku rozwiązania powinien zostać wydrukowany
//napis BR, a w przypadku nieskończenie wielu rozwiązań napis NWR


//Example 1
//Input:
//0.52 1.60 -5.44


//Output:
//-13.54



//Example 2
//Input:
//0.00 2.00 3.00


//Output:
//BR


//Example 3
//Input:
//0.00 2.00 2.00


//Output:
//NWR

namespace JROWLIN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wynik = 0;
            string y;
            while ((y = Console.ReadLine()) != null)
            {
                string[] liczby = y.Split(' ');
                decimal n1 = decimal.Parse(liczby[0]);
                decimal n2 = decimal.Parse(liczby[1]);
                decimal n3 = decimal.Parse(liczby[2]);
                if (n1 == 0)
                {
                    if ((n3 - n2) == 0)
                    {
                        Console.WriteLine("NWR");
                    }
                    else
                    {
                        Console.WriteLine("BR");
                    }
                }
                else
                {
                    wynik = (-n2 + n3) / n1;
                    Console.WriteLine("{0:N2}", decimal.Round(wynik, 2, MidpointRounding.AwayFromZero));
                }
            }
        }
    }
}
