using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_14_Ogrenci_Ortalaması_Hesaplama
{
    public class ogrenci
    {
        public void ogrenciNotHesapla(string ad, string soyad, decimal not1, decimal not2, decimal not3 = 45) 
            // not3 opsiyonel parametre olduğu için ından sonra yazılacak parametreler opsiyonel olması lazım yoksa hata verir ör: decimal not4=0
            //genellikle opsiyonel olanlar en sonda tanımlanır.
        {
            Console.WriteLine("Öğrencinin Bilgileri Aşağıdaki Gibidir.");
            Console.WriteLine("Ad Soyad  : {0} {1}", ad, soyad);

            decimal ortalama = ortalamaHesapla(not1, not2, not3);
           
            ortalamaNotDegerlendir(ortalama);

            ortalamaNotDegerlendir(ortalamaHesapla(not1, not2, not3));
        }

         void ortalamaNotDegerlendir(decimal ogrenciOrtalama)  // başına belirleyici yazmazsak burada olduğu gibi private algılar
        {
            if (ogrenciOrtalama < 45)
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Kaldınız", ogrenciOrtalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz : {0} - Geçtiniz", ogrenciOrtalama);
            }
        }

        private decimal ortalamaHesapla(decimal Ogrencinot1, decimal Ogrencinot2, decimal Ogrencinot3)
        {
            //decimal ortalama = (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;
            //return ortalama;
            return (Ogrencinot1 + Ogrencinot2 + Ogrencinot3) / 3;
        }
    }
}
