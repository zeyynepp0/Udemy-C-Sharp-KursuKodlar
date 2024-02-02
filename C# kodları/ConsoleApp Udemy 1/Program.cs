using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_1
{
    internal class Program
    {
        static void Main(string[] args)


        {
            #region sistemin çalıışma zamanında oluşturduğu 1 ile 10 arasındali bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım.
            int sistemUretSayi = 0;
            int tahminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);


            while (true)
            {
                Console.Write("{0} . deneme - lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz :", tahminAdet);

                string rndKullaniciGelen = Console.ReadLine();

                int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);


                //if (int.Parse(rndKullaniciGelen)== sistemUretSayi)
                if (rndKullaniciGelenInt == sistemUretSayi)
                {
                    Console.WriteLine("{0} . denemenizde değeri buldunuz Tebrikler !", tahminAdet);
                    Console.WriteLine("Sistemin bulduğu sayı : " + sistemUretSayi);
                    break;
                }
                else
                {
                    Console.WriteLine("{0} . denemeniz , Tahmin edemediniz lütfen yeniden deneyin ..." , tahminAdet);
                    tahminAdet++;
                }

               
            }

            Console.ReadLine();
        }
        #endregion
    }
}
