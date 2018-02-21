using System;
//Gra Euklidesa przebiega według następujących zasad:

//W grze bierze udział dwóch graczy(A i B). Początkowo każdy z nich 
//dysponuje pewną niezerową liczbą identycznych żetonów - odpowiednio a i b.
//Jeżeli jeden z graczy ma mniej żetonów niż drugi, może wykonać ruch.
//Wykonując ruch, gracz zabiera partnerowi tyle żetonów, ile sam posiada.
//Żetony te są wyłączone z dalszej gry 
//(tj.gracz wykonujący ruch ich nie przejmuje).
//Gra kończy się w sytuacji, gdy żaden z graczy nie może wykonać ruchu
//(w szczególności gra może skończyć się bezpośrednio po "rozdaniu" żetonów,
//bez jakichkolwiek ruchów).
//Znając początkowe zasoby graczy(tj.wartości a i b), wyznacz łączną liczbę 
//żetonów pozostałych w grze w chwili jej zakończenia.

//Wejście
//t[1 <= t <= 10; liczba partii]
//a1 b1[1 <= a1, b1 <= 1 000 000 000; początkowe liczby żetonów u
//graczy(partia #1) ]

//a2 b2[jw. (partia #2) ]
//...
//at bt
//Wyjście
//r1[łączna liczba żetonów u obu graczy po zakończeniu partii #1 ]
//r2[jw., dla partii #2 ]
//...
//rt


//Przykład
//Wejście:
//3
//1 1
//2 4
//9 6


//Wyjście:
//2
//4
//6
namespace EUCGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1, V2, ile;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                V1 = Convert.ToInt32(a[0]);
                V2 = Convert.ToInt32(a[1]);

                while (V1 != V2)
                {
                    while (V1 > V2)
                    {
                        V1 -= V2;
                    }
                    while (V2 > V1)
                    {
                        V2 -= V1;
                    }
                }

                Console.WriteLine(V2 + V1);
            }
            Console.ReadKey();
        }
    }
}
