using System;
//Pesel
//Jan Kowalski musi wpisać do systemu szpitalnego dane osobowe pacjenta, 
//oprócz imienia i nazwiska musi również wpisać PESEL pacjenta.
//Jakież było jego zdziwienie, gdy spostrzegł, że pewnych pacjentów 
//system nie przyjmował z powodu wadliwego PESELu.

//Twoim zadaniem jest sprawdzenie, czy podana liczba 11-cyfrowa 
//jest poprawnym PESELem.


//Aby sprawdzić czy dany PESEL jest prawidłowy należy wykonać następujące
//działania:


//Pierwszą cyfrę mnożymy przez 1,
//drugą cyfrę mnożymy przez 3,
//trzecią cyfrę mnożymy przez 7,
//czwarta cyfrę mnożymy przez 9,
//piątą cyfrę mnożymy przez 1,
//szóstą cyfrę mnożymy przez 3,
//siódmą cyfrę mnożymy przez 7,
//ósmą cyfrę mnożymy przez 9,
//dziewiątą cyfrę mnożymy przez 1,
//dziesiątą cyfrę mnożymy przez 3,
//jedenastą cyfrę mnożymy przez 1.


//Tak uzyskane 11 iloczynów dodajemy do siebie.Jeśli ostatnia cyfra 
//tej sumy jest zerem to podany PESEL jest prawidłowy. 
//Przykład dla numeru PESEL 44051401458

//4*1 + 4*3 + 0*7 + 5*9 + 1*1 + 4*3 + 0*7 + 1*9 + 4*1 + 5*3 + 8*1 =
//= 4 + 12 + 0 + 45 + 1 + 12 + 0 + 9 + 4 + 15 + 8 = 110


//Źródło: www.wikipedia.pl

//Jeśli suma jest większa od zera, wtedy sprawdzamy jej poprawność. 
//W przeciwnym przypadku nr PESEL jest błędny.Ponieważ ostatnia 
//cyfra liczby 110 jest zerem więc podany PESEL jest prawidłowy.

//Na wejściu podana jest w pojedyńczej linii ilość t<=100 numerów PESEL
//do sprawdzenia.W kolejnych t liniach są 11-cyfrowe liczby.


//Output
//W pojedyńczej linii powinna zostać wyświetlona litera D, jeśli numer 
//PESEL jest poprawny lub N, gdy nie.


//Example
//Input:
//2
//44051401458
//12345678901


//Output:
//D
//N
namespace JPESEL
{
    class Program
    {
        static void Main(string[] args)
        {
            string wynik = "";
            int ile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ile; i++)
            {
                string b = Console.ReadLine();
                for (int j = 0; j < b.Length; j++)
                {
                    wynik += b[j] + " ";
                }
                string[] a = wynik.Split(' ');
                //
                int wynik2 = Convert.ToInt32(a[0]) * 1 + Convert.ToInt32(a[1]) * 3 + Convert.ToInt32(a[2]) * 7 + Convert.ToInt32(a[3]) * 9 + Convert.ToInt32(a[4]) * 1 + Convert.ToInt32(a[5]) * 3 + Convert.ToInt32(a[6]) * 7 + Convert.ToInt32(a[7]) * 9 + Convert.ToInt32(a[8]) * 1 + Convert.ToInt32(a[9]) * 3 + Convert.ToInt32(a[10]) * 1; ;
                //Console.WriteLine(wynik2);
                string wyn = Convert.ToString(wynik2);
                if (wyn.EndsWith("0"))
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("N");
                }
                wynik2 = 0;
                wynik = "";
            }
            Console.ReadKey();
        }
    }
}
