using System;
//Napisz program, który działa jak prosty kalkulator obsługujący pięć 
//operacji: dodawanie, odejmowanie, mnożenie, dzielenie i obliczanie
//reszty z dzielenia liczb całkowitych.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona liczba zestawów 
//danych. Zestawy składają się z jednoznakowego symbolu operacji 
//do wykonania (+ dodawanie, - odejmowanie, * mnożenie, 
//dzielenie całkowitoliczbowe, % reszta z dzielenia) 
//oraz następujących po nim dwóch liczb całkowitych. 
//Poszczególne składowe zestawu zostaną rozdzielone spacjami, a same 
//zestawy znakiem nowej linii.Liczba testów nie przekracza 100, wynik 
//zawiera się w typie int32.

//Wyjście
//Na wyjściu programu ma się pojawić ciąg liczb będących rezultatem 
//wykonania pojawiających się na wejściu poleceń. Poszczególne liczby 
//należy rozdzielić znakami nowej linii.Uwaga! Można założyć, że dane 
//wejściowe nie zawierają polecenia dzielenia przez 0.


//Przykład
//Wejście:
//+ 7 9
//- 0 4
//* 5 6
/// 8 3
//% 5 2


//Wyjście:
//16
//-4
//30
//2
//1
namespace CALC
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
                string a = liczby[0];
                int b = int.Parse(liczby[1]);
                int c = int.Parse(liczby[2]);
                if (Convert.ToChar(a) == '+')
                {
                    wynik = b + c;
                }
                if (Convert.ToChar(a) == '-')
                {
                    wynik = b - c;
                }
                if (Convert.ToChar(a) == '*')
                {
                    wynik = b * c;
                }
                if (Convert.ToChar(a) == '/')
                {
                    wynik = b / c;
                }
                if (Convert.ToChar(a) == '%')
                {
                    wynik = b % c;
                }
                Console.WriteLine(wynik);
                wynik = 0;
            }
        }
    }
}
