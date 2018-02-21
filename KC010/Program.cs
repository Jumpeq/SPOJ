using System;
//Napisz program, który liczy, ile wyrazów i liczb znajduje się w podanej 
//linii.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona ilość zestawów 
//danych.Poszczególne zestawy składają sie z liczb całkowitych
//i wyrazów(wyraz = ciąg liter) rozdzielonych spacjami oraz kończą
//się znakiem nowej linii.

//Wyjście
//Na wyjściu ma się pojawić ilość liczb i wyrazów znajdujących się 
//w poszczególnych liniach. Ilość liczb należy oddzielić spacją od ilości 
//wyrazów, a po ilości wyrazów ma się pojawić znak nowej linii.


//Przykład
//Wejście:
//Romek ma 2 koty i 3 psy
//2 plus 2 jest rowne 4


//Wyjście:
//2 5
//3 3
namespace KC010
{
    class Program
    {
        static bool IsInt(string sVal)
        {
            foreach (char c in sVal)
            {
                int iN = (int)c;
                if ((iN > 57) || (iN < 48))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string an;
            while ((an = Console.ReadLine()) != null)
            {
                string[] liczby = an.Split(' ');
                int zliczCYFR = 0;
                int zliczLITER = 0;
                for (int i = 0; i < liczby.Length; i++)
                {
                    if (IsInt(liczby[i]))
                    {
                        zliczCYFR++;
                    }
                    else
                    {
                        zliczLITER++;
                    }
                }
                Console.WriteLine("{0} {1}", zliczCYFR, zliczLITER);
            }
        }
    }
}
