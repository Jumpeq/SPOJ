using System;
//Zadanie: POT(Czy umiesz potęgować)
//Dla danych dwóch liczb naturalnych a i b, wyznaczyć ostatnią cyfrę
//liczby a^b.

//Zadanie
//Napisz program, który:
//wczyta ze standardowego wejścia: podstawę a oraz wykładnik b,
//wyznaczy ostatnią cyfrę liczby a^b,
//wypisze wynik na standardowe wyjście.
//Wejście
//W pierwszej linii wejścia znajduje się jedna liczba całkowia D (1≤D≤10), 
//oznaczjąca liczbę przypadków do rozważenia. Opis każdego przypadku podany 
//jest w jednym wierszu, zawierającym dwie liczby naturalne a i b oddzielone
//pojedynczym odstępem(spacją), takie, że(1 ≤ a, b ≤ 1 000 000 000).

//Wyjście
//Dla każdego przypadku z wejścia Twój program powinien wypisać(w osobnej 
//linii dla każdego przypadku z wejścia) cyfrę jedności liczby a^b zapisanej 
//dziesiętnie.

//Przykład
//Dla danych wejściowych:
//2
//2 3
//3 3
//poprawną odpowiedzią jest:
//8
//7
namespace PA05_POT
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, d = 0;
            ulong a, b;
            t = Convert.ToInt32(Console.ReadLine());
            for (double i = 0; i < t; i++)
            {
                string[] c = Console.ReadLine().Split(' ');
                a = Convert.ToUInt64(c[0]);
                b = Convert.ToUInt64(c[1]);
                if (a == 10)
                {
                    d = 0;
                }
                else
                {
                    a = a % 10;
                }
                switch (a)
                {
                    case 0:
                        {
                            d = 0;
                            break;
                        }
                    case 1:
                        {
                            d = 1;
                            break;
                        }
                    case 2:
                        {
                            if (b % 4 == 1) d = 2;
                            if (b % 4 == 2) d = 4;
                            if (b % 4 == 3) d = 8;
                            if (b % 4 == 0) d = 6;
                            break;
                        }
                    case 3:
                        {
                            if (b % 4 == 1) d = 3;
                            if (b % 4 == 2) d = 9;
                            if (b % 4 == 3) d = 7;
                            if (b % 4 == 0) d = 1;
                            break;
                        }
                    case 4:
                        {
                            if (b % 4 == 1 || b % 4 == 3) d = 4;
                            if (b % 4 == 2 || b % 4 == 0) d = 6;
                            break;
                        }
                    case 5:
                        {
                            d = 5;
                            break;
                        }
                    case 6:
                        {
                            d = 6;
                            break;
                        }
                    case 7:
                        {
                            if (b % 4 == 1) d = 7;
                            if (b % 4 == 2) d = 9;
                            if (b % 4 == 3) d = 3;
                            if (b % 4 == 0) d = 1;
                            break;
                        }
                    case 8:
                        {
                            if (b % 4 == 1) d = 8;
                            if (b % 4 == 2) d = 4;
                            if (b % 4 == 3) d = 2;
                            if (b % 4 == 0) d = 6;
                            break;
                        }
                    case 9:
                        {
                            if (b % 4 == 1 || b % 4 == 3) d = 9;
                            if (b % 4 == 2 || b % 4 == 0) d = 1;
                            break;
                        }
                }
                if (b == 0)
                {
                    d = 1;
                }
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
