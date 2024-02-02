using System;
using System.Collections; // SortedList için bu kütüphane eklenir.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_9_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedList içerisinde bulunan datayı sıralar (key göre)
            SortedList Sortedl = new SortedList();
            Sortedl.Add(100, "Yüz");
            Sortedl.Add(90, "Doksan");
            Sortedl.Add(1, "Bir");
            Sortedl.Add(7000, "Yedibin");
            //Sortedl.Add("A", "B");    // Hata alırız çünkü bunları sıralayamaz
            //Buradan anlayacağımız key veri tipimizin aynı olmasımlazım yoksa hata alırız
            // Keylerde string başlarsak string devam etmeliyiz, int başlarsak int devam etmeliyiz ...
            // HashTable aynı metotlara sahiptir.
        }
    }
}
