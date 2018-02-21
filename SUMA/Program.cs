using System;
//Napisz program, który oblicza sumę pojawiających się na wejściu liczb.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona, ale niewielka 
//ilość małych liczb całkowitych(z zakresu -100..100). 
//Poszczególne liczby zostaną rozdzielone znakiem nowej linii.

//Wyjście
//Na wyjściu ma się pojawić ciąg liczbowy, którego i-ta pozycja jest równa 
//sumie i pierwszych wczytanych z wejścia liczb.Poszczególne liczby
//należy rozdzielić znakami nowej linii.

//Przykład
//Wejście:
//6
//8
//-3

//Wyjście:
//6
//14
//11
namespace SUMA
{
    class Program
    {
        static void Main(string[] args)
        {
            string ile;
            int wynik = 0;
            while ((ile = Console.ReadLine()) != null)
            {
                string[] liczby = ile.Split(' ');
                int a = int.Parse(liczby[0]);
                wynik += a;
                Console.WriteLine(wynik);
            }
        }
    }
}
