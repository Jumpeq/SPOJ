using System;
//Wiek segmentolka
//Jaś chodzi do czwartej klasy.Jest bardzo ciekawy świata, a szczególnie 
//interesuje się przyrodą.Pewnego dnia Jaś udał się na wycieczkę 
//nad pobliski staw, gdzie oglądał różne napotkane zwierzątka.
//Szczególnie zaciekawiło go żyjątko przypominające z wyglądu dżdżownicę, 
//której wyrosły nóżki.Jaś przypomniał sobie, że kilka dni wcześniej 
//w szkole nauczycielka opowiadała o tym stworzonku.Nazywa się segmentolek, 
//składa się bowiem z ciągu dużej liczby segmentów, z których każdy może 
//posiadać pewną liczbę nóżek. Codziennie każdy segment segmentolka może 
//podzielić się na dwa segmenty albo może z niego wyrosnąć dodatkowa nóżka.
//W przypadku podziału segmentów pewna - być może zerowa - 
//liczba nóżek "przechodzi" do pierwszego powstałego segmentu, 
//a reszta do drugiego.Z segmentu, który ulega podziałowi, nie może 
//tego samego dnia wyrosnąć nóżka.Segmentolki rodzą się jako jeden segment
//bez nóżek i rosną przez całe życie - każdego dnia dzieli się przynajmniej
//jeden segment lub wyrasta przynajmniej jedna nowa nóżka.

//Segmentolek znaleziony przez Jasia był bardzo duży i rozrośnięty.
//Na podstawie jego budowy Jaś chciał obliczyć, ile dni ma to stworzonko.
//Niestety ze względu na ogromną ilość segmentów Jaś ciągle się mylił
//w rachunkach.Zrezygnowany już miał smutny wrócić do domu, ale nagle
//wpadł mu do głowy genialny pomysł. "Rodzice są informatykami.
//Na pewno coś wymyślą!". Jesteś rodzicem Jasia.
//Twoim zadaniem jest napisać program obliczający maksymalny możliwy wiek 
//segmentolków.

//Wejście
//Pierwsza linia wejścia zawiera liczbę całkowitą t - liczbę zestawów 
//danych, których opisy występują kolejno po sobie. Każdy zestaw opisany 
//jest przez jedną linię wejścia, składającą się z nieujemnych liczb 
//całkowitych pooddzielanych spacjami. Pierwszą liczbą jest n (1 ≤ n ≤ 104) 
//- liczba segmentów segmentolka.Po tej liczbie występuje n nieujemnych 
//liczb całkowitych, niewiększych niż 105, oznaczających liczby 
//nóżek wyrastających z kolejnych segmentów.

//Wyjście
//Dla każdego zestawu danych wypisz liczbę oznaczającą maksymalny możliwy 
//wiek segmentolka wyrażony w dniach.

//Przykład
//Wejście:

//3
//1 0
//1 5
//4 0 0 0 0

//Wyjście:

//0
//5
//3
namespace WSEGA
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile, segmenty, wiek;
            int[] tab = null;
            ile = Convert.ToInt32(Console.ReadLine());
            while (ile != 0)
            {
                string[] y = Console.ReadLine().Split(' ');
                segmenty = Convert.ToInt32(y[0]);
                wiek = 0;
                for (int j = 1; j <= segmenty; j++)
                {
                    wiek += Convert.ToInt32(y[j]);
                }
                Console.WriteLine(wiek + segmenty - 1);
                ile--;
            }

            Console.ReadKey();
        }
    }
}
