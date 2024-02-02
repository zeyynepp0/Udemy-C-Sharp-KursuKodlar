using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_13_Matematiksel_İşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();

            YenidenIslemYap:

            M.menuHazırla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. sayı değerini giriniz");
            decimal kullaniciSayi1= decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayı değerini giriniz");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1:
                   sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;

                case 2:
                    sonuc = M.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;

                case 3:
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;

                case 4:
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;

                default:
                    Console.WriteLine("Belirtmiş olduğunuz deper liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen yeniden deneyiniz.");
                    System.Threading.Thread.Sleep(1000);
                    goto YenidenIslemYap;
            }
            Console.WriteLine("Yeniden işlem yaomak istiyor msusunuz ? [E/H] ");
            string EH = Console.ReadLine();
            if (EH =="E" || EH == "e")
            {
                goto YenidenIslemYap;
            }

        }
    }
}
