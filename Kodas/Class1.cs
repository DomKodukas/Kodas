using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matke
{
    internal class klase
    {
        public double b;
        public int kiek;
        public void Sk()
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
        }
    }
}