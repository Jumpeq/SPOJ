using System;
//Bajtockie Linie Lotnicze wzbogaciły swoją flotę o nowy model samolotu.
//W samolocie tym jest n1 rzędów miejsc siedzących w klasie biznesowej 
//oraz n2 rzędów w klasie ekonomicznej. W klasie biznesowej każdy 
//rząd ma k1 miejsc siedzących, a w klasie ekonomicznej — k2 miejsc.

//Zadanie
//Napisz program, który:
//wczyta informacje na temat dostępnych miejsc siedzących w samolocie,
//wyznaczy sumaryczną liczbę wszystkich miejsc siedzących,
//wypisze wynik
//Wejście
//W pierwszym i jedynym wierszu wejścia znajdują się cztery liczby
//naturalne n1, k1, n2, i k2 (1<=n1, k1, n2, k2<=1000), pooddzielane 
//pojedynczymi odstępami.

//   Wyjście
//   Pierwszy i jedyny wiersz wyjścia powinien zawierać jedną liczbę 
//całkowitą - liczbę miejsc siedzących w analizowanym samolocie.

//   Przykład
//   Wejście
//   2 5 3 20


//   Wyjście
//   70
namespace POTSAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string y1;
            while (((y1 = Console.ReadLine()) != null))
            {
                string[] y = y1.Split(' ');
                int n1 = Convert.ToInt32(y[0]);
                int n2 = Convert.ToInt32(y[1]);
                int n3 = Convert.ToInt32(y[2]);
                int n4 = Convert.ToInt32(y[3]);
                Console.WriteLine(n1 * n2 + n3 * n4);
            }
        }
    }
}
