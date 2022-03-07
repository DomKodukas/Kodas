using System;
using System.Threading;
namespace testas
{
    class Program
    {
        static void Main(string[] args)
        {
            matke.klase myObj = new matke.klase();
            myObj.Sk();
            Console.WriteLine("Elementu kiekis : " + myObj.kiek);
            Console.WriteLine("Atsakymas : " + myObj.b);

            DateTime start = DateTime.Now;
            Thread.Sleep(0);
            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);
            Console.WriteLine("Praejas laikas {0} ms", ts.TotalMilliseconds);
            while (true) ;
        }
    }
}