using System; // Bir kutuphane dosyasını uygulamamızın içerisine eklemektir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_12__Metot_Gnel_Tanım
{
    internal class Program
    {
        static void Main(string[] args) // Program main metodu içinde çalışır
        {
            // Uzun bir şekilde yazım.
            //System.Console.Write("Merhaba");
            // using kısmında kütüphane eklenmiş hali işe yazımı.
            //Console.Write("merhaba");

            Selamla();


            //bir class oluşturup oluşturduğumuz metodu çağırdık.
            Ogrenci O1 = new Ogrenci(); // bir nesne oluşturduk
            O1.SelamlaOgrenci();

            O1.OgrenciMetot1("Zeynep", "Can");

           

            Console.ReadLine();
        }

        static void Selamla() //void = metot çalışacak ama herhangi bit değer dönmeyecek anlamına geliyor.
        {
            Console.WriteLine("Merhaba");
        }

    }
}
