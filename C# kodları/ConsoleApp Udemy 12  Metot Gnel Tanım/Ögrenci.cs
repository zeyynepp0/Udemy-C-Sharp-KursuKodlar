using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_12__Metot_Gnel_Tanım
{
    public class Ogrenci // bütün uygulama içerisinde kullanabilmek için public ekledik.
    {

        public void SelamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci");
        }



        /*
         *  [ErişimBelirleyici] <GeriDonusdegeri> MetotAdi (parametreler(parametrelere ihtiyacı yoksa yani bir işlem yapmayacaksa sadece () yapmamız yeterli. ))
         * {
         *  metot için gereken kodlar...
         * }
         * 
         * Erişim Belirleyicisi :
         * 1-Public = Benim class ulaşan herkessin benim metodumada ulaşmasını istiyorum.
         * 2-Private = Benim oluşturduğum metot içinde oluşturulduğu class tarafından sadece ulaşılsın.
         * 3-Protected = birbirinden nesneler kalıtıldığında kullanılıyor
         * 4-Internal = İlgili kütüphane içerisinde ulaşabilirsin
         * 5-Internal Protected = İlgili kütüphane içerisinde ulaşabilirsin veya bir yerden kalıtıydıysa ulaşabilirsin.
         * 
         */


        public void OgrenciMetot1 (string ogrenciAdi, string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1} ", ogrenciAdi, ogrenciSoyadi);
        }

        private void OgrenciMetot2(string ogrenciAdi2, string ogrenciSoyadi2)
        {
            Console.WriteLine("Öğrenci Bilgileri : {0} {1} ", ogrenciAdi2, ogrenciSoyadi2);
        }
    }
}
