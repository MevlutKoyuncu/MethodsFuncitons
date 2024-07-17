using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    internal class Cirak
    {

        public string isim;

        public void SelamSoyle()
        {
            Console.WriteLine("Ustam selam söyledi.");
        }
        //Parametre alan metot
        public void IsmeSelamSoyle(string isim)
        {
            Console.WriteLine(isim + "abi ustam selam söyledi.");
        }
        //Metot sınırsız sayıda parametre alabilir!!!256
        //Parametreler farklı türlerde olabilir.
        /// <summary>
        /// İsme çok selam söylemek için kullanılan metot
        /// </summary>
        /// <param name="isim">Kime söyleneceği</param>
        /// <param name="adet">Ne kadar selam söyleneceği</param>
        public void IsmeCokSelamSoyle(string isim, int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(isim + " abi ustam selam söyledi.");
            }
        }
        public double CaySoyle(double para)
        {
            double cayfiyat = 5;
            double kalan = para - cayfiyat;
            return kalan;

        }
        public string AdinNe()
        {
            return "Benim Adım " + isim;
        }
        public string selamver()
        {
            return "Selamunaleyküm";

        }
    }
}
