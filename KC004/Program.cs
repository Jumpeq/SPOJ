using System;
//Napisz program, który sprawdza, ile razy dana liczba całkowita wystąpiła 
//w danym ciągu.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona liczba zestawów 
//danych.Każdy z zestawów składa się z trzech rozdzielonych spacjami części:
//poszukiwanej liczby całkowitej, długości przeszukiwanego ciągu 
//oraz samego ciągu.Poszczególne liczby w ciągu zostały rozdzielone spacjami;
//zestawy odseparowano od siebie znakiem nowej linii.

//Wyjście
//Na wyjściu ma się pojawić ciąg liczbowy, którego i-ty wyraz jest
//równy ilości wystąpień liczby podanej w pierwszej części i-tego wczytanego
//z wejścia zestawu w ciągu stanowiącym trzecią część tego zestawu.
//Poszczególne elementy tego ciągu należy rozdzielić znakiem nowej linii.


//Przykład
//Wejście:
//1 3 11 1 7
//2 4 1 2 4 3
//3 5 2 2 2 2 2
//4 4 4 4 4 4


//Wyjście:
//1
//1
//0
//4
namespace KC004
{
    class Program
    {
        static void Main(string[] args)
        {
            string an;
            while ((an = Console.ReadLine()) != null)
            {
                string[] liczby = an.Split(' ');
                double x = Convert.ToDouble(liczby[0]);
                double y = Convert.ToDouble(liczby[1]);
                int zliczacz = 0;
                for (int i = 2; i <= y + 1; i++)
                {
                    if (x == Convert.ToDouble(liczby[i]))
                    {
                        zliczacz++;
                    }
                }
                Console.WriteLine(zliczacz);
            }
        }
    }
}
