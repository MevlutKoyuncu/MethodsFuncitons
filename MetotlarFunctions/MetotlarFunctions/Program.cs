using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tanımlama

            //İhtiyaç duyulduğunda çalıştırılmak üzere tanımlanan küçük program parçasına Function(Metot) denir.
            //Metotlar sadece ait olduğu nesnesi ile çağırıldığında çalışırlar.

            #endregion

            #region Çırak sınıfı ile metotları öğreniyorum

            //Cirak c = new Cirak();
            //c.isim = "Süleyman";
            //c.SelamSoyle();

            //c.IsmeSelamSoyle("Numan ");

            //c.IsmeCokSelamSoyle("Muhittin", 4);

            //double paraustu = c.CaySoyle(20);
            //Console.WriteLine("Paraüstü = " + paraustu);

            //string isim = c.AdinNe();
            //Console.WriteLine(isim);
            //Console.WriteLine(c.AdinNe());

            //Console.WriteLine(c.selamver());

            //Cirak c2= new Cirak();
            //c2.isim = "Ahmet";
            //Console.WriteLine(c2.AdinNe());

            #endregion

            #region Matematik sınıfı ile metotları kullanıyorum.

            Calculator mat = new Calculator();

            //Console.WriteLine("Bir sayı giriniz ");
            //double sayi = Convert.ToDouble(Console.ReadLine());

            //double gelen = mat.KareAl(sayi);
            //Console.WriteLine("Sayının karesi = " + mat.KareAl(sayi));

            //Console.WriteLine("Taban giriniz = ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üs giriniz = ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(mat.UsAl(sayi1, sayi2));

            #endregion

            #region ÖDEV - Şu ana kadar yaptığımız her şeyi matematik sınıfı içerisinde yap.



            #endregion

            #region Metin işlem sınıfı

            MetinIslem mi= new MetinIslem();
            Console.WriteLine("Lütfen metin giriniz ");
            string isim = Console.ReadLine();
            Console.WriteLine(mi.BoslukSil(isim));

            #endregion

            #region ÖDEV - Metin işlemleri için şimdiye gördüğümüz her şeyi yap.

            #endregion

        }
    }
}
