using System;
//Pociąg z miejscowości A do B jedzie z prędkością v1, a wraca z miejscowości 
//B do A z prędkością v2. Obliczyć średnią prędkość na całej trasie. Uwaga: 
//Dane wejściowe będą tak dobrane, aby wynik był liczba całkowitą.

//Wejście
//Na wejściu znajduje się dokładnie jedna liczba całkowita t(1<=t<=1000) 
//oznaczająca liczbę zestawów danych.W wierszach od 2 do t+1 znajdują się
//dwie liczby całkowite oddzielone spacja v1 oraz v2 (1<=v1, v2<=10000).

//Wyjście
//Wyjście składa się z t wierszy.W każdym wierszu powinna znaleźć się dokładnie
//jedna liczba całkowita oznaczająca średnią prędkość.

//Przykład
//Wejście:
//2
//50 50
//60 40

//Wyjście:
//50
//48
namespace VSR
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1, V2, ile;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                V1 = Convert.ToInt32(a[0]);
                V2 = Convert.ToInt32(a[1]);
                Console.WriteLine(Convert.ToInt32((2 * V1 * V2) / (V1 + V2)));
            }
            Console.ReadKey();
        }
    }
}
