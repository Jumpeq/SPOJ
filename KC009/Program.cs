using System;
//Napisz program, który zapisuje wspak podane na wejściu wyrazy.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona ilość wyrazów, 
//tj.ciągów znaków zbudowanych z małych liter. Poszczególne wyrazy zostaną 
//rozdzielone znakiem nowej linii.Przyjmujemy, że długość wyrazów 
//nie przekracza 1000 znaków.

//Wyjście
//Na wyjściu mają się pojawić te same wyrazy, które pojawiły się na wejściu,
//ale zapisane wspak.Poszczególne wyrazy należy rozdzielić znakiem nowej
//linii.

//Przykład
//Wejście:
//alfa
//beta
//gamma

//Wyjście:
//afla
//ateb
//ammag
namespace KC009
{
    class Program
    {
        static string Odwracacz(string an)
        {
            char[] wyrazy = an.ToCharArray();
            Array.Reverse(wyrazy);
            return new string(wyrazy);
        }
        static void Main(string[] args)
        {
            string an;
            while ((an = Console.ReadLine()) != null)
            {
                Console.WriteLine(Odwracacz(an));
            }
        }
    }
}
