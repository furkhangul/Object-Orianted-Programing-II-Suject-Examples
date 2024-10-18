using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyon02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Koleksiyonlar";
            ArrayList koleksiyon = new ArrayList();
            ArrayList diger = new ArrayList(3);
            diger.Add(324.234);
            diger.Add(true);
            diger.Add(new object());
            koleksiyon.AddRange(diger);

            foreach (var eleman in koleksiyon)
                Console.WriteLine(eleman);

            Console.WriteLine("-------------------");

            foreach (var item in diger)
                Console.WriteLine(item);

            Console.Read();


        }
    }
}
