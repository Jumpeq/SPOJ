using System;
//Napisz program, który sprawdza, czy istnieje trójkąt o bokach o podanej 
//długości.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona liczba zestawów
//danych. Każdy z zestawów składa się z 3 liczb rozdzielonych spacjami.
//Poszczególne zestawy zostaną rozdzielone znakiem nowej linii.

//Wyjście
//Na wyjściu ma się pojawić ciąg binarny, którego i-ty wyraz jest równy 1,
//jeżeli istnieje trójkąt o długościach boków podanych w i-tym wczytanym 
//z wejścia zestawie.Poszczególne elementy tego ciągu należy rozdzielić 
//znakiem nowej linii.

//Przykład
//Wejście:
//1.2 1.2 1.2
//1.5 2.5 3.5
//-1.5 6.0 4.5
//2 4 8

//Wyjście:
//1
//1
//0
//0
namespace KC003
{
    class Program
    {
        static double Max(double x, double y, double z)
        {
            double max;
            max = x;
            if (y > max) max = y;
            if (z > max) max = z;
            return max;
        }
        static void Main(string[] args)
        {
            string an;
            while ((an = Console.ReadLine()) != null)
            {
                string[] liczby = an.Split(' ');
                double x = Convert.ToDouble(liczby[0]);
                double y = Convert.ToDouble(liczby[1]);
                double z = Convert.ToDouble(liczby[2]);
                double najwieksza = Max(x, y, z);
                if (x == najwieksza)
                {
                    if (najwieksza < y + z)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else if (y == najwieksza)
                {
                    if (najwieksza < x + z)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else if (z == najwieksza)
                {
                    if (najwieksza < y + x)
                    {
                        Console.WriteLine("1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }

            }
        }
    }
}
