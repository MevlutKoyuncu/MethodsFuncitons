using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    internal class Calculator
    {

        public double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }

        //Üs alma metotu yazınız.

        public int UsAl (int sayi1, int sayi2)
        {
            int usluSayi = 1;
            for (int i = 0; i < sayi2; i++)
            {
                usluSayi *= sayi1;
            }
            return usluSayi;
        }

    }
}
