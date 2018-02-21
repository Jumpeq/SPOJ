using System;
//Szyfr Cezara jest to szyfr za pomocą, którego Juliusz Cezar szyfrował 
//swoje listy do Cycerona.Jako ciekawostkę można podać, że szyfr ten był 
//podobno używany jeszcze w 1915 roku w armii rosyjskiej, gdyż tylko tak 
//prosty szyfr wydawał się zrozumiały dla sztabowców.

//Każdą literę tekstu jawnego zamieniamy na literę przesuniętą o 3 miejsca
//w prawo.I tak literę A szyfrujemy jako literę D, literę B jako E itd.
//W przypadku litery Z wybieramy literę C. W celu odszyfrowania tekstu 
//powtarzamy operację tym razem przesuwając litery o 3 pozycje w lewo.

//Input
//Na wejściu pojawi się tekst zawierający jedynie wielkie litery alfabetu 
//łacińskiego, spacje oraz znaki nowej linii, a jego długość 
//nie przekracza 200 znaków.

//Output
//Na wyjściu otrzymujemy zaszyfrowany tekst używając Szyfru Cezara.

//Example
//Input:
//ABC DEF
//TERA EST ROTUNDA

//Output:
//DEF GHI
//WHUD HVW URWXQGD
namespace JSZYCER
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            while (((y = Console.ReadLine())) != null)
            {
                int przesuniecie = 3;
                for (int i = 0; i < y.Length; i++)
                {
                    int liczba = y[i];
                    int x = 0;
                    if (liczba > 64 && liczba < 88)
                    {
                        x = liczba + przesuniecie;
                    }
                    else if (liczba == 88)
                    {
                        x = liczba - 23;
                    }
                    else if (liczba == 89)
                    {
                        x = liczba - 23;
                    }
                    else if (liczba == 90)
                    {
                        x = liczba - 23;
                    }
                    else if (liczba == 32)
                    {
                        x = 32;
                    }
                    else
                    {
                        x = liczba + przesuniecie;
                    }
                    char znakzm = (char)x;
                    Console.Write(znakzm);
                }
                Console.WriteLine();
            }
        }
    }
}
