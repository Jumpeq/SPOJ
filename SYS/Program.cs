using System;
//Zadanie polega na zamianie podanej liczby n, która jest w systemie
//dziesiątkowym, na liczbę w systemie szesnastkowym
//(cyfry:0,1,2,3,4,5,6,7,8,9, A, B, C, D, E, F) 
//i jedenastkowym(cyfry:0,1,2,3,4,5,6,7,8,9, A).

//Wejście
//W pierwszym wierszu wejścia znajduje się dokładnie jedna t(1<=t<=10000) 
//oznaczająca liczbę zestawów danych.W każdym wierszu od 2 do t+1 znajduje 
//się dokładnie jedna liczba całkowita n (1<=n<=106).

//Wyjście
//W każdym wierszu wyjścia powinny znaleźć się dokładnie dwie liczby, 
//pierwsza - oznaczająca podana liczbę w systemie szesnastkowym, 
//druga - oznaczająca podana liczbę w systemie jedenastkowym.

//Przykład
//Wejście:
//2
//1263
//10

//Wyjście:
//4EF A49
//A A
namespace SYS
{
    class Program
    {
        static int charToValue(char c)
        {
            if (c >= '0' && c <= '9')
                return c - '0';
            if (c >= 'A' && c <= 'F')
                return c - 'A';
            return 0;
        }
        static char valueToChar(int value)
        {
            if (value >= 0 && value <= 9)
                return (char)('0' + value);
            if (value >= 10 && value <= 15)
                return (char)('A' + (value - 10));
            return '0';
        }
        static string Konwersja(int system1, int system2, string liczba)
        {
            int wartosc = 0;
            int pot = 1;
            for (int i = liczba.Length - 1; i >= 0; i--)
            {
                wartosc += pot * charToValue(liczba[i]);
                pot *= system1;
            }
            pot = 1;
            while (pot * system2 <= wartosc)
                pot *= system2;
            string s = "";
            while (pot > 0)
            {
                int ilew = wartosc / pot;
                wartosc -= pot * ilew;
                s += valueToChar(ilew);
                pot /= system2;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int ile;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string a = Console.ReadLine();
                Console.WriteLine("{0} {1}", Konwersja(10, 16, a), Konwersja(10, 11, a));
            }
            Console.ReadKey();
        }
    }
}
