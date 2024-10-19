using System;
using System.Collections;

class Program
{
    static void Main()
    {

        //Soru 5 //
        /*
        Bir koleksiyona başka bir koleksiyonun elemanlarını ekleme:
        - Bir `ArrayList` koleksiyonu oluşturun ve içerisine çeşitli veri türlerinden elemanlar
        ekleyin.
        - Başka bir `ArrayList` koleksiyonunu ilkine ekleyin.
        - Her iki koleksiyonun elemanlarını sırayla ekrana yazdırın.
         */

        ArrayList liste1 = new ArrayList { "Elma", "Armut", "Kivi" };
        ArrayList liste2 = new ArrayList { "Kiraz", "Karput", "Kavun" };

        liste1.AddRange(liste2);

        foreach (var i in liste1) 
        {
            Console.WriteLine(i);
        }

    }
}
