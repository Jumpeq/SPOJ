using System;
//Napisz program, który działa jak prosty kalkulator z pamięcią obsługujący 
//pięć operacji: dodawanie, odejmowanie, mnożenie, dzielenie 
//i obliczanie reszty z dzielenia liczb całkowitych.Przyjmujemy, że nasz 
//kalkulator ma w pamięci 10 rejestrów o numerach 0 - 9 oraz że wszystkie 
//rejestry zawierają na początku zera.

//Wejście
//Na wejście programu podana zostanie pewna nieokreślona liczba zestawów 
//danych.Zestawy składają się z jednoznakowego symbolu operacji do wykonania 
//(+, -, *, /, % i z) oraz następujących po nim dwóch liczb całkowitych.

//Wyjście
//Na wyjściu programu ma się pojawić ciąg liczb będących rezultatem 
//wykonania pojawiających się na wejściu poleceń.Poszczególne liczby 
//należy rozdzielić znakami nowej linii.To, co należy wykonać, 
//zależy od symbolu operacji.Symbole +, -, *, / i % nakazują wykonanie 
//odpowiednio dodawania, odejmowania, mnożenia, dzielenia i obliczenia
//reszty z dzielenia liczb, które są przechowywane w rejestrach o podanych
//numerach. Symbol z nakazuje zapis wartości podanej jako drugi argument 
//w rejestrze o numerze podanym jako pierwszy argument. 
//(Po wykonaniu tej operacji nie trzeba nic wyświetlać).
//Uwaga! Można założyć, że dane wejściowe nie zawierają polecenia
//dzielenia przez 0.

//Przykład
//Wejście:
//z 3 6
//z 1 89
//z 2 60
//z 0 11
//+ 0 1
//- 1 2
//* 2 3
/// 3 0
//% 3 1

//Wyjście:
//100
//29
//360
//0
//6
namespace CALC2
{
    class Program
    {
        static void Main(string[] args)
        {
            char dzialanie;
            int nr_rejestru;
            int liczba;
            int wynik;
            string ile;
            int[] rejestr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                rejestr[i] = 0;
            }
            while ((ile = Console.ReadLine()) != null)
            {
                string[] liczby = ile.Split(' ');
                dzialanie = Convert.ToChar(liczby[0]);
                nr_rejestru = int.Parse(liczby[1]);
                liczba = int.Parse(liczby[2]);
                switch (dzialanie)
                {
                    case 'z':
                        rejestr[nr_rejestru] = liczba;
                        break;

                    case '+':
                        wynik = rejestr[nr_rejestru] + rejestr[liczba];
                        Console.WriteLine(wynik);
                        break;

                    case '-':
                        wynik = rejestr[nr_rejestru] - rejestr[liczba];
                        Console.WriteLine(wynik);
                        break;

                    case '*':
                        wynik = rejestr[nr_rejestru] * rejestr[liczba];
                        Console.WriteLine(wynik);
                        break;

                    case '/':
                        wynik = rejestr[nr_rejestru] / rejestr[liczba];
                        Console.WriteLine(wynik);
                        break;

                    case '%':
                        wynik = rejestr[nr_rejestru] % rejestr[liczba];
                        Console.WriteLine(wynik);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
