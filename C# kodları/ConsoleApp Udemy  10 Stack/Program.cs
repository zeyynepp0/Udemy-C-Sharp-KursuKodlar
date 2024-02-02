using System;
using System.Collections; // Stack
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy__10_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İçerisinde bulunan dataları bir komut kullanarak sıralı bir şekilde kendi içerisinden çıkarılmasını sağlıyor.
           // son giren data ilk çıkar (Last in, first out)
           // Proje konularında çok yoğun kullanılacak
            Stack S1 = new Stack();
            S1.Push(" 1 Bir yol var ama her yerde tuzak"); // Bir datayı object tipinde koleksiyona ekler
            S1.Push(" 2 Bir yol daha var, dönmek de yasak");
            S1.Push(" 3 Deryaya yakın, dünyadan uzak");
            S1.Push(" 4 Gel vazgeçelim hiç zorlamadan");
            S1.Push(" 5 Sen aklı selim, ben yorgun adam");
            S1.Push(" 6 Bir yer bulalım, dünyadan uzak");

            object O1 = S1.Pop(); // içerisinde tuttukları değerleri object olarak geri dönerler.
            //Datayı göderiyor ama koleksiyondan kaldırmıyor.Datayı göderip listeden çıkardı

            object O2 = S1.Peek(); // içerisinde tuttukları değerleri object olarak geri dönerler
            //Datayı gönderip koleksiyondan çıkarmayacak
        }
    }
}