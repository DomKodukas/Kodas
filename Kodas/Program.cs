using System;
using System.Threading;
namespace testas
{
    class Program
    {
        public static void Main(string[] args)
        {
            matke.klase myObj = new matke.klase();

            Console.WriteLine("Elementu kiekis : " + myObj.kiek);//ELEMENTO KIEKIO SPAUSDINIMAS
            Console.WriteLine("Atsakymas : " + myObj.b);//SUSKAICIUOTO ATSAKYMO SPAUSDINIMAS
            Console.WriteLine();//TARPAS TARP EILUCIU
            Console.WriteLine("Faktorialas is " + myObj.skaicius + " yra : " + myObj.fakt);//FATORIALO SPAUSDINIMAS

            Console.WriteLine();//TARPAS TARP EILUCIU
            //DEBUG KODAS KURIS DUOS SUPRASTI PER KIEK LAIKO KODAS SUVEIKE
            DateTime start = DateTime.Now;
            Thread.Sleep(0);
            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);
            Console.WriteLine("Praejas laikas {0} ms", ts.TotalMilliseconds);//SPAUSDINAMAS ATSAKYMAS
            while (true) ;
        }
    }
}