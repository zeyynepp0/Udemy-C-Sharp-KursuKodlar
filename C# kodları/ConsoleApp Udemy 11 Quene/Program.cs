using System;
using System.Collections; // Queue
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Udemy_11_Quene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ilk giren ilk çıkar (first in ,first out)
            Queue Q1 = new Queue();
            Q1.Enqueue("Bir");
            Q1.Enqueue("İki");
            Q1.Enqueue("Üç");
            Q1.Enqueue("Dört");

            object O1 =Q1.Peek();
            object O2 = Q1.Dequeue();// Koleksiyonun içerisinden ilgili değeri siler
        }
    }
}
