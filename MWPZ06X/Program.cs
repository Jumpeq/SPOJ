using System;
//Tata Jasia kupił nową działkę.Był ze swojego zakupu bardzo dumny! 
//Pierwsze co zrobił po podpisaniu umowy to zabrał całą rodzinę,
//aby obejrzeć nową działkę.Wśród nich był Jaś.

//Jasiowi działka też bardzo się podobała.Tata poinstruował go, 
//że zgodnie z obserwacjami Jasia, działka ma kształt idealnego 
//kwadratu.Jaś natychmiast przypomniał sobie ze szkoły ostatnią 
//lekcję matematyki, na której to uczył się, jak obliczać 
//powierzchnie kwadratów. Wystarczyło więc, żeby znał długość 
//jednego boku działki, a już wiedziałby, jaką powierzchnię ma 
//całość. Potrzebował tylko tego jednego wymiaru.

//Tata zajął się z mamą rozpatrywaniem wizji na temat wykorzystania 
//tak wspaniałego kawałka ziemi. Jaś więc nie mając w nich pomocy, 
//nie zwracając na nich uwagi, poszedł do narożnika działki. 
//Tam stanął i zacząć stawiać wzdłuż płotu równe kroki.
//Gdy doszedł do drugiego narożnika znał już długość jednego 
//boku, dzięki czemu mógł już obliczyć powierzchnię całej działki! 
//Niestety, samo rachowanie nie jest jeszcze jego mocną stroną, więc 
//potrzebuje pomocy.

//Znając liczbę kroków wyliczonych przez Jasia, oblicz 
//powierzchnię działki w „krokach kwadratowych Jasia”.

//Wejście
//Pierwsza linia wejścia zawiera liczbę całkowitą D (1 ≤ D ≤ 500)
//oznaczającą liczbę zestawów danych.Każdy zestaw składa się
//z jednej dodatniej liczby całkowitej X (1 ≤ X ≤ 1000) określającej 
//liczbę kroków wyliczonych przez Jasia.

//Wyjście
//Dla każdego zestawu danych należy wypisać w osobnej linii 
//jedną liczbę oznaczającą powierzchnię działki w „krokach kwadratowych Jasia”.


//Przykład
//Wejście:

//2
//5
//3


//Wyjście:

//25
//9
namespace MWPZ06X
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int d;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                d = Convert.ToInt32(a[0]);
                int z;
                z = d * d;
                Console.WriteLine(z);
            }
            Console.ReadKey();
        }
    }
}
