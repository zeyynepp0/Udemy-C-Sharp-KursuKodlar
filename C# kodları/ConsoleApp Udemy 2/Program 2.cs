using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp_Udemy_2
{
    internal class program
    { 
        static void Main(string[] args) 
        {
            int tahmin = 0;
            int uretilenSayi = 0;
            int sayac = 0;

            Console.Write("Tahmin oyunu için en yüksek değeri giriniz : ");
            int kullaniciMaxValue = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            uretilenSayi = rnd.Next(1,kullaniciMaxValue);

            do
            {
                sayac++;
                Console.WriteLine("{0} hakkınız üretilen sayıyı tahmin ediniz ", sayac );
                tahmin = int.Parse(Console.ReadLine());
            }
            while(tahmin!= uretilenSayi);
            Console.WriteLine("{0} . kere denediniz sayıyı tahmin ettiniz ", sayac);


            Console.ReadLine();
        }
    }
}



