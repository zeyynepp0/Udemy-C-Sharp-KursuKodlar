using System;
using System.Collections; // Hastable için gerekli kütüphane
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_7_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni değer ekleme

            H1.Add("Car", "Araba"); // Add (object key object value) key değerleri benzersiz olmalı(aynı key değeri kullanmamalıyız)
                                    // ve key değerlerini dataya ulaşmak için kullanırız. Value değerleri aynı olabilir.
            H1.Add("House", "Ev");  // key = Car , Valu =Araba 
            H1.Add("Cars", "Araba");

            #endregion


            #region Yardımcı metotlar

            bool Kontrol1 = H1.Contains("House"); // key değerlerinde olup olmadığını arar
            bool Kontrol2 = H1.Contains("Door");
            bool Kontrol3 = H1.Contains("Ev");
            bool Kontrol4 = H1.ContainsKey("House"); // key değerlerinde olup olmadığını arar
            bool Kontrol55= H1.ContainsValue("Araba"); // value değerlerinde olup olmadığını arar

            H1["House"] = "Villa"; // House değerimizi karşılığını güncelledik (House = Villa)

            H1.Remove("Cars"); // key kısmından siler

            int koleksiyonIcindekitoplamDeger = H1.Count;

            H1.Clear(); // koleksiyonun içerisindeki tüm datayı temizleriz.
            #endregion
        }
    }
}
