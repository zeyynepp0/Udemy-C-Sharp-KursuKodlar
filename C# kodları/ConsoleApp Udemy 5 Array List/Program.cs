using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_5_Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 elemanlı (string) ArrayList içindekileri Z-A olacak şekilde sıralama
            
            ArrayList odevList = new ArrayList();
            odevList.Add("Zeynep");
            odevList.Add("Ali");
            odevList.Add("İbrahim");
            odevList.Add("Fatih");
            odevList.Add("Zehra");
            odevList.Add("Elif");
            odevList.Add("Meryem");
            odevList.Add("Aytuğ");
            odevList.Add("Kardelen");
            odevList.Add("Bünyamin");

            // tüm değerleri A-Z sırala, sonra listeyi tersten tekrardan sırala
            odevList.Sort();
            odevList.Reverse();

            Console.WriteLine("ArrayList İçindeki Elemanların Z-A sıralanmış hali:");
            foreach (var eleman in odevList)
            {
                Console.WriteLine(eleman);
            }

            Console.ReadLine();
        }
    }
}
