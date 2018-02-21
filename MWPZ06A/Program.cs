using System;
//Ciążowy specjalista
//W pewnym małym miasteczku rozchorowała się nauczycielka biologii.
//Dla tak małego miasteczka okazało się to ogromnie wielkim problemem.
//W okolicy nie było nikogo kto mógłby i chciałby zastąpić nauczycielkę 
//ucząc dzieci w podstawówce biologii. Zwłaszcza, że akurat zgodnie 
//z programem trzeba by zacząć przerabiać bardzo trudne tematy dotyczące 
//rozmnażania zwierząt.Ponieważ nie było chętnych, dyrektor zadecydował,
//że dopóki nauczycielka nie wróci do szkoły, lekcje biologii będzie 
//przeprowadzał nauczyciel matematyki. Mimo iż był on temu bardzo niechętny,
//nie mógł odmówić swojemu dyrektorowi.

//Na pierwszej lekcji, którą miał przeprowadzić zgodnie z programem 
//nauczania, powinien powiedzieć o tym, jak różnorodne mogą być długości 
//ciąży u ssaków. Tak się akurat składało, że dzień wcześniej jego kolega,
//matematyk z dużego miasta, przesłał mu mejlem taką zagadkę:

//Matka jest o 21 lat starsza od swojego dziecka.Za 6 lat dziecko 
//będzie 5 razy młodsze od matki. Pytanie: Gdzie jest ojciec?

//Rozwiązując tę zagadkę matematyk spostrzegł, że obliczył bez problemu 
//moment poczęcia (chwila obecna) i urodzenia dziecka, czyli poznał długość
//trwania ciąży człowieka. Wpadł więc na doskonały pomysł, aby tylko 
//modyﬁkować dane tego zadania, podstawiając odpowiednie gatunki zwierząt,
//i w ten sposób, uczyć bawiąc, pozwolić uczniom na poznanie długości
//trwania ciąży różnych zwierząt.

//Niestety uczniowie okazali się mniej entuzjastycznie nastawieni 
//do zagadki, a pomysł rozwiązywania łamigłówek matematycznych nie tylko 
//na matematyce, ale także na lekcjach biologii, wydał im się mało traﬁony.
//Dlatego zamiast obliczać długości ciąży różnych gatunków zwierząt 
//poprosili Cię o napisanie programu, który zrobi to za nich.

//Dla danego gatunku zwierząt znając różnicę wieku między matką a dzieckiem, 
//oraz wiedząc, kiedy dziecko będzie ile razy młodsze od matki, ustal 
//długość trwania ciąży.

//Wejście
//Pierwsza linia wejścia zawiera liczbę całkowitą D (1 ≤ D ≤ 500) 
//oznaczającą liczbę zestawów danych.Każdy zestaw znajduje się w osobnej 
//linii i składa się z 3 liczb całkowitych X, Y, Z (1 ≤ X, Y, Z ≤ 1000, Z > 1). 
//Po ich podstawieniu do zagadki brzmi ona następująco: 
//"Matka jest o X lat starsza od swojego dziecka. Za Y lat dziecko b
//ędzie Z razy młodsze od matki."

//Wyjście
//Dla każdego zestawu danych należy wypisać w osobnej linii jedną liczbę 
//– długość trwania ciąży badanego gatunku zwierząt.Aby trzymać się
//standardów biologicznych, długość ta powinna być wyrażona w liczbie 
//miesięcy, które trwa ciąża.Ponieważ biologów nie interesują dokładne 
//wartości ułamkowe, a wszystko jest zaokrąglane, ty także musisz 
//zaokrąglić swój wynik do najbliższej liczby całkowitej i wypisać 
//go na wyjście.

//Uwaga: Zakładamy, że nauczyciel obliczył wcześniej sam wszystkie 
//zadania i każde dane dają prawidłowy wynik, tzn.można na ich podstawie 
//wyliczyć długość ciąży, która jest zawsze pewną dodatnią wartością 
//(co oczywiście nie musi oznaczać, że wyjście musi być zawsze dodatnie).

//Przykład
//Wejście:

//3
//21 6 5
//11 1 13
//223 2 113

//Wyjście:

//9
//1
//0
namespace MWPZ06A
{
    class Program
    {
        static void Main(string[] args)
        {
            double ile;
            double x, y, z;
            double wynik = 0;
            ile = Convert.ToInt32(Console.ReadLine());
            for (double i = 0; i < ile; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                x = Convert.ToInt64(a[0]);
                y = Convert.ToInt64(a[1]);
                z = Convert.ToInt64(a[2]);
                wynik = ((x - z * y + y) / (z - 1)) * (-12);
                Console.WriteLine(Math.Round(wynik));
                wynik = 0;
            }
            Console.ReadKey();
        }
    }
}
