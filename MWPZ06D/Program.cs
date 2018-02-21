using System;
//Jaś ma pojutrze imieniny.Jak dla każdego małego chłopca, jest to bardzo
//miły dzień w jego życiu. Na pewno dostanie mnóstwo prezentów, słodkości
//i innych pyszności. Jednak Jaś chodzi do szkoły, a jego imieniny wypadają
//akurat w dzień, który żadnym świętem nie jest i musi do niej pójść.
//Nie to jednak jest w tym najgorsze, że trzeba tam iść, zamiast cały dzień 
//świętować objadając się pysznościami przygotowanymi przez mamę. 
//Najgorsze jest to, że jak każdy inny mały chłopiec w szkole, Jaś musi 
//rozdać swoim kolegom i koleżankom cukierki w czasie jednej z lekcji.
//Jest to zadanie, którego Jaś szalenie wręcz nie lubi. Jednak nie może
//nic z tym zrobić – taka jest tradycja, a nie chce okłamywać mamy,
//że rozdał cukierki, naprawdę ich nie rozdając. Zresztą...wstyd przed 
//całą klasą – mieć imieniny i nie mieć cukierków – nie, nie, absolutnie 
//nie wchodzi to w grę.

//Mama już zakupiła odpowiednią ilość cukierków. Ponieważ ich rozdawanie
//jest ogromnie ważne, mama już dziś położyła cukierki tuż przy plecaku
//Jasia w jego pokoju, aby na pewno ich nie zapomniał. A tymczasem 
//on nie może przez to spać. Cukierki, przypominając zapachem o swojej 
//obecności, przywołują u Jasia strasznie niemiłe wspomnienia zeszłorocznych
//imienin i cukierków w klasie, kiedy na oczach całej podśmiechującej 
//się klasy musiał się całować z panią nauczycielką...

//Jaś postanowił odpędzić złe myśli zabijając w jakiś sposób czas. 
//Wziął torebkę z cukierkami i postanowił je policzyć. 
//Policzył jednak bardzo szybko i znów złe myśli przyszły mu do głowy.
//Zdecydował więc, że musi się dowiedzieć, czy w tym roku też zostaną 
//dla niego cukierki, jak w zeszłym, czy może tym razem mama się poprawiła
//w obliczeniach.Jaś wiedział, ile w jego klasie jest osób i wiedział, 
//że nie może nikogo wyróżnić – każdy musi dostać taką samą liczbę 
//cukierków, oprócz niego samego, który nie je ich wtedy w szkole.
//Był dobrym kolegą, więc każdemu chciał dać jak najwięcej. 
//Jednak, jeśli nie dało się rozdać w taki sposób wszystkich cukierków,
//te które zostały Jaś brał z powrotem do domu i mógł sam je zjeść.

//Obliczenie, czy coś mu zostanie było ponad jego siły, biednego,
//małego chłopca. Poprosił więc Ciebie o pomoc.Wiedząc ile osób liczy
//klasa Jasia oraz ile cukierków kupiła mama oblicz, czy po ich 
//rozdaniu wśród kolegów i koleżanek Jasia, zostanie jeszcze coś 
//dla niego na wieczór.

//Wejście
//Pierwsza linia wejścia zawiera liczbę całkowitą D (1 ≤ D ≤ 500)
//oznaczającą liczbę zestawów danych.Wejście składa się z dwóch 
//liczb całkowitych L i C (1 ≤ L, C ≤ 109) oznaczających odpowiednio 
//liczbę osób w klasie Jasia oraz liczbę cukierków, które kupiła mama.

//Wyjście
//Dla każdego zestawu danych należy wypisać w osobnej linii słowo TAK, 
//jeśli coś dla Jasia zostanie lub NIE, jeśli rozda on dokładnie wszystkie
//cukierki.


//Przykład
//Wejście:

//2
//3 2
//55 22


//Wyjście:


//NIE
//TAK
namespace MWPZ06D
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            int dz, cu;
            ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ile; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                dz = Convert.ToInt32(a[0]);
                cu = Convert.ToInt32(a[1]);
                if (dz == 1)
                {
                    Console.WriteLine("TAK");
                }
                else if (cu == 0)
                {
                    Console.WriteLine("NIE");
                }
                else if (cu % (dz - 1) == 0)
                {
                    Console.WriteLine("NIE");
                }
                else if (dz < cu)
                {
                    if (cu % (dz - 1) == 0)
                    {
                        Console.WriteLine("NIE");
                    }
                    else
                    {
                        Console.WriteLine("TAK");
                    }
                }
                else if (dz != 1)
                {
                    if (cu % (dz - 1) == 0)
                    {
                        Console.WriteLine("NIE");
                    }
                    else
                    {
                        Console.WriteLine("TAK");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
