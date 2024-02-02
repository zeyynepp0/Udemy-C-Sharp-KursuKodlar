using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // Array listkullandığımız için ekledik.


namespace ConsoleApp_Udemy_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] isimler = new string[10];

            int Capacity = 0;
            int Count = 0;

            ArrayList A1 = new ArrayList();

            // Tek değer ekleme

            A1.Add("Zeynep Can");

            Capacity = A1.Capacity; // capacity başlangıçta 4 ile başlar sonra 4'er 4'er artar ve bu kodun sonunda capacity = 8 olur
            Count = A1.Count; // count her yeni veri geldiğinde bir artar ve bu kodun sonunda count = 5 olur

            A1.Add(100);



            // Birden fazla değer ekleme

            ArrayList A2 = new ArrayList();
            A2.Add("Bahar");
            A2.Add("Yasin");
            A2.Add("Veli");

            A1.AddRange(A2); //A1'in içine A2 eklemeyi sağlar. Böylece A1 içinde 5 tane değer olur.




            // Capacity ve Count İnceleme

            Capacity = A1.Capacity;
            Count = A1.Count;




            // Koleksiyon içindeki değerlere ulaşmak ve ilgili veri tipinde dönüştürdük

            object o1 = A1[3];
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];




            // Koleksiyon içersindeki değeri değiştirme

            A1[4] = "Aslan Kaplan";




            // ArrayList sıralama


            // Dizinin mevcut elemanlarını ters olarak sıralama
            A1.Reverse();  /* bu komut çalıştığında en başta bulunan değer en sona gelecek şekilde
                           tüm komutlar yer baştan sona yer değiştirir.*/


            A1.Remove(100);  // A-Z sıralama yaparken hata almıyalım diye int verimizi siliyorum


            // A-Z sıralama
            A1.Sort(); //dizi içinde sıralama yapıyorsak değerlerimiz sıralama yapabileceğimiz şekilde olmalı (int. dounle vb olmamalı)





            //  Koleksiyonlar yardımcı komutlar

            int IndexDegeri = A1.IndexOf("Yasin"); //A1 içinde Yasin ara ve kaçıncı index'te olduğunu bul.

            /*
            if (A1.Contains("Yakup"))
            {
            int IndexDegeri = A1.IndexOf("Yasin"); 
            A1.RemoveAt(IndexDegeri);
            }
            */

            object[] D1 = A1.ToArray(); // ToArray komutu bizim arraylist içerisinde bulunan tüm verileri bize dizi olarak verir (bir kopyasını dizi olarak aktarır).






            A1.Clear(); // Array koleksiyonunun içerisinde ne varsa sileriz.
            A1.TrimToSize(); // Kapasitenin ilk haline dönmesini sağlar bu örnekte 82den 4'e (eski haline dönmesini sağladı).



            bool kontrol1 = A1.Contains("Bahar"); // contains A1 içinde bahar ya da 500 olduğunu arar eğer varsa true yoksa false değerini döndürecektir.
            bool konrtrol2 = A1.Contains(500);


            // ArrayList koleksiyonu içerisindeki değeri silme (değeri siler ve altta değer varsa değer onunyerine geçer.
            A1.Remove("Yasin");
            A1.RemoveRange(2, 2); //2. elemandan başlayıp 2 tane değer silecek
            A1.RemoveAt(3); //3 numaralı index silinir



            Console.ReadLine();
        }
    }
}
