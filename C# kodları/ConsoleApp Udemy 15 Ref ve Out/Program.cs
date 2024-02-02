using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_15_Ref_ve_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ref ve Out anahtar sözcüklerinde eski .net framework versyonlarında 1 fark vardı.
            // mevcut framework versiyonu 7.0 olanlar bu farktan etkilenmeyecekler. 

            //int sayi1;
            //degerAta(out sayi1);

            topla(5, 9, 20, 45, 22, 12, 11, 56, 3213, 3213, 21231, 23, 21, 321, 321, 321, 432, 43, 23, 1321, 132);
        }

        static void degerAta(out int gelenDeger)
        {
            gelenDeger = 10;
        }

        static void topla(params int[] sayilar)  // params ifadesi belirtilmiş veri tipinden dizi elde eder.yani istediği datayı diziye aktarır
        // params ifedemiz son ifademiz olmalı yani params önce değişkenlerimizi yazmalıyızzz
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("Toplam :{0}", toplam);
        }
    }
}
