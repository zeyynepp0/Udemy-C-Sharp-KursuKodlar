using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] isimListesi = new string[5];

            isimListesi[0] = "Zeynep CAN";
            isimListesi[1] = "Güneş";
            isimListesi[2] = "Öykü";
            isimListesi[3] = "Abidin";
            isimListesi[4] = "Ali";
            */

            /* foreach (string isim in isimListesi)
             {
                 Console.WriteLine(isim);
             }
            */

            /*
            for (int i = 0; i < isimListesi.Length; i++)
            {
                string gelenisim = isimListesi[i];
                Console.WriteLine(gelenisim);
            }
            */

            #region
            /*
            Console.Write("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz :");
            string uygulamaDiziUzunluk = Console.ReadLine();
            int uygulamaDiziUzunlukInt = int.Parse(uygulamaDiziUzunluk);

            int[] uygulamaDizi = new int[uygulamaDiziUzunlukInt];

            for ( int uygulamaSayac= 0; uygulamaSayac < uygulamaDizi.Length; uygulamaSayac++  )
            {
                Console.WriteLine("{0}. index' e denk gelen değeri giriniz" , uygulamaSayac);
                uygulamaDizi[uygulamaSayac] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz");

            Console.WriteLine("Dizi içerisindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir.");

            int uygulamaToplam = 0, uygulamaOrtalama = 0;

            foreach (int  item in uygulamaDizi)
            {
                //Console.WriteLine(item);
                uygulamaToplam = uygulamaToplam + item;
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Dizi içerisindeki sayıların toplamı = " + uygulamaToplam);

            Console.WriteLine("Dizi içersindeki eleman sayısı : {0} ", uygulamaDizi.Length);
            uygulamaOrtalama = uygulamaToplam / uygulamaDizi.Length;
            Console.WriteLine("Ortalama: {0}", uygulamaOrtalama); 
            */
            #endregion



            #region
            // 20 elemalı bit int dizi oluşturalım. Değerlerini random sınıfının next
            // fonksiyonunu ile 1 - 10 arasındaki değerler ile dolduralım.
            //  Daha sonra dizi  içerisindeki  elemanları ekrana yazdıralım ve
            //  ilgili dizi içerisinde kaç tane  4 değeri olduğunu bulalım.

            Random rnd = new Random();

            int[] uygulama2Dizi = new int[20];

            for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            {
                uygulama2Dizi[uygulama2Sayac] = rnd.Next(1, 10);
            }

            int uygulama2Bul = 0;

            foreach (var item in uygulama2Dizi)
            {
                Console.WriteLine(item);
                if (item == 4)
                    uygulama2Bul++;
            }
            Console.WriteLine("Dizi içindeki 4 değeri {0}" , uygulama2Bul);
            #endregion






            Console.ReadLine();
        }
    }
}
