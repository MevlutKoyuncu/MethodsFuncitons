using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    internal class MetinIslem
    {
        //Kendisine gönderilen metnin başından boşlukları silen metot
        public string BoslukSil(string metin)
        {
            int index = -1;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] != ' ')
                {
                    index = i;
                    break;

                }
            }
            string yenimetin = "";
            for (int i = index; i < metin.Length; i++)
            {
                yenimetin += metin[i];
            }
            return yenimetin;
        }
    }
}
