using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_8_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hashtable içerisine ENG - TR olarak data eklemek
             Yeni kayıt eklemek E/H
             E : Yeni kayıt ekleme işlemi devam etsin
             H : Tüm listeyi yazdırın
             var olan bir key değeri ekliyor ise kullanıcıya bu değer daha önceden ... şeklinde sistemimizde bulunmaktadır.
             */

            Hashtable sozlukVeriTabani = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istidğiniz sözlük değerini yazınız");
                Console.WriteLine("EN : ");
                string eng = Console.ReadLine();

                bool kontrol = sozlukVeriTabani.ContainsKey(eng);
                if (kontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz değer {0} sözlük içerisinde bulunmaktadır. {1} değerin türkçe karşılığıdır.", eng, sozlukVeriTabani[eng].ToString());
                }
                else
                {
                    Console.WriteLine("{0} ingilizce değerinin türkçe karşılığını yazınız", eng);
                    string tr = Console.ReadLine();
                    sozlukVeriTabani.Add(eng,tr);
                    Console.WriteLine("Değer ekleme işlemi başarılı");
                }
                Console.WriteLine("Yeni değer eklemek istiyor musunuz ? (E/H)");
            }
            while (Console.ReadLine().ToUpper() != "H");

            // 1. yöntem
            foreach (var item in sozlukVeriTabani.Keys)
            {
                Console.WriteLine("ENG : {0} = TR : {1}", item , sozlukVeriTabani[item]);
            }

            // 2. yöntem
            foreach (DictionaryEntry item in sozlukVeriTabani)
            {
                // Console.WriteLine(item.GetType().Name);    // bu kod satırını var yazınca veri türümüzü bulmak için kullanırız veri türünü bulduktan sonra var yerine veri türümüzü yazıp
                // bu kodu silip kodumuzun devamını yazabiliriz.

                Console.WriteLine("Eng : {0} = TR : {1}", item.Key, item.Value);

            }

            Console.ReadLine();
        }
    }
}
