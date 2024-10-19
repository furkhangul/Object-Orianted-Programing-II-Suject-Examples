using System;
using System.Collections;

class Program
{
    static void Main()
    {

        //Soru 4 //

        /*          
        Farklı veri türlerini bir `ArrayList` koleksiyonuna ekleme:
        - `ArrayList` sınıfını kullanarak farklı veri türlerinden elemanlar ekleyin (örneğin: string, integer, boolean).
        - Koleksiyonun içeriğini ekrana yazdırın
         */

        ArrayList yeniliste = new ArrayList();
        yeniliste.Add("Furkan Gül");
        yeniliste.Add(20);
        yeniliste.Add("Yazılım mühendisliği");
        yeniliste.Add(2004);
        yeniliste.Add(1.75);
        yeniliste.Add(true);

        foreach(var i in yeniliste)
        {
            Console.WriteLine(i);
        }
    }
}
