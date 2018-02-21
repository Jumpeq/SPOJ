using System;
//Napisz program, który oblicza sumę trzech liczb całkowitych.

//Wejście
//Na wejście programu podane zostaną trzy liczby 
//całkowite(nieprzekraczające 100) rozdzielone znakiem nowej linii.

//Wyjście
//Na wyjściu ma się pojawić suma liczb, które pojawiły się na wejściu.

//Przykład
//Wejście:
//100
//-68
//12


//Wyjście:
//44
namespace KC001
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(y1 + y2 + y3);
        }
    }
}
