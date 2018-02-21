using System;
//Flamaster
//Kasia niedawno poznała wszystkie literki w szkole.Z wielką pasją 
//potrafiła całe dnie spędzać na pisaniu długich słów swoim ulubionym 
//flamastrem.Pisała i pisała "tasiemce" tak długo, aż flamaster wypisał się.
//Kasia posmutniała. Z trudem, ale udało jej się uprosić swoją mamę, 
//aby kupiła jej nowy pisak.Musiała jednak obiecać, że tym razem
//będzie bardziej oszczędna przy jego używaniu żeby wystarczył na dłużej.
//Kasia zaczęła zastanawiać się w jaki sposób będzie mogła zrealizować 
//obietnicę daną mamie.

//Postanowiła, że aby zaoszczędzić wkład flamastra będzie wypisywała 
//skróconą wersję wymyślanych wyrazów.Jeśli miała zamiar napisać więcej 
//niż dwie takie same literki obok siebie w wyrazie, to teraz napisze 
//literkę a następnie liczbę, określającą ilość wystąpień tej literki.
//Zadanie
//Twoim zadaniem jest dla zadanego wyrazu, który wymyśliła Kasia,
//podanie skróconej wersji tego wyrazu.
//Wejście
//W pierwszej linijce wejścia znajduje się liczba naturalna C, 1 ≤ C ≤ 50,
//oznaczająca ilość zestawów danych. W kolejnych C wierszach wejścia 
//znajdują się zestawy danych.Każdy zestaw składa się z niepustego wyrazu 
//złożonego z samych dużych liter alfabetu amerykańskiego. 
//Długość wyrazu nie przekracza 200 znaków.
//Wyjście
//Dla każdego zestawu danych, dla zadanego wyrazu, na wyjściu powinna
//znaleźć się jego skrócona wersja.

//Przykład
//Dla danych wejściowych:
//4
//OPSS
//ABCDEF
//ABBCCCDDDDEEEEEFGGHIIJKKKL
//AAAAAAAAAABBBBBBBBBBBBBBBB
//prawidłowym rozwiązaniem jest:
//OPSS
//ABCDEF
//ABBC3D4E5FGGHIIJK3L
//A10B16
namespace FLAMASTE
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            string wyraz = "";

            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] z = Console.ReadLine().Split('\n');
                wyraz = z[0];
                char[] znak = new char[wyraz.Length];
                for (int j = 0; j < wyraz.Length; j++)
                {
                    znak[j] = wyraz[j];
                }
                int counter = 1;
                for (int j = 0; j < wyraz.Length; j++)
                {
                    if (j < wyraz.Length - 1 && znak[j] == znak[j + 1])
                    {
                        counter++;
                    }
                    if (counter <= 2)
                    {
                        Console.Write(znak[j]);
                    }
                    if (j < wyraz.Length - 1 && znak[j] != znak[j + 1] && counter <= 2)
                    {
                        counter = 1;
                    }
                    else if (j < wyraz.Length - 1 && znak[j] != znak[j + 1] && counter > 2)
                    {
                        Console.Write(counter);
                        counter = 1;
                    }
                    else if (j == wyraz.Length - 1 && j != 0 && znak[j] == znak[j - 1] && counter > 2)
                    {
                        Console.Write(counter);
                        counter = 1;
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
