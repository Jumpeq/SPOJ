using System;
//Napisz program, który wyznacza liczbę pierwiastków rzeczywistych równania
//kwadratowego.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona, ale niewielka 
//ilość zestawów danych.Każdy zestaw składać się będzie z 3 liczb 
//rzeczywistych (współczynników A, B i C równania Ax^2 + Bx + C = 0)
//rozdzielonych spacjami.Poszczególne zestawy zostaną rozdzielone znakiem 
//nowej linii. Można przyjąć, że A jest różne od zera.


//Wyjście
//Na wyjściu ma się pojawić ciąg liczbowy, którego i-ta pozycja jest równa
//liczbie pierwiastków rzeczywistych i-tego wczytanego z wejścia równania.
//Poszczególne liczby należy rozdzielić znakami nowej linii.

//Przykład
//Wejście:
//0.3 0.3 0.4
//0.5 1 0.5
//-0.5 -0.5 0


//Wyjście:
//0
//1
//2
namespace ROWNANIE
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            while (((y = Console.ReadLine())) != null)
            {
                double tmp = 0;
                string[] z = y.Split(' ');
                for (int j = 0; j < z.Length; j++)
                {
                    tmp = Convert.ToDouble(z[1]) * Convert.ToDouble(z[1]) - 4 * Convert.ToDouble(z[0]) * Convert.ToDouble(z[2]);
                }
                if (tmp < 0)
                {
                    Console.WriteLine("0");
                }
                else if (tmp == 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("2");
                }
                tmp = 0;
            }
            Console.ReadKey();
        }
    }
}
