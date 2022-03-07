using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matke
{
    internal class klase
    {
        public double b;//SUKURTAS KINTAMASIS
        public int kiek;//SUKURTAS KINTAMASIS
        public int i, fakt = 1, skaicius = 5;//SUKURTAS KINTAMASIS
        public klase()
        //ELEMENTO SKAICIAVIMAS
        {
            kiek = 2;
            double isvedimas = 0;
            double a = 1;
            b = 2;
            double galas = Math.Pow(10, 15);
            while (b <= galas)
            {
                kiek++;
                isvedimas = a * b;
                a = b;
                b = isvedimas;
            }
            //FAKTORIALO SKAICIAVIMO CIKLIUKAS
            for (i = 1; i <= skaicius; i++)
            {
                fakt = fakt * i;
            }
        }
    }
}