using System;

class Program
{
    //Ref ve Out C# üzerinde yoğun olarak kullanılan terimlerdir.
    //Bu iki terim parametrelerin değer geçirme şekillerini kontrol eder.
    //Ancak farklı işlevlere yararlar.
    static void Main()
    {
        //ref anahtar kelimesi bir parametrenin metodun içerisinde değiştirilmesini sağlar.
        //ref ile bir parametreyi kullanmadan önce o parametrenin bir değere sahip olması gerekmektedir.
        //yani parametreyi metodun çağırılmasından önce kullanmamız gerekmektedir.

        int x = 15;
        Console.WriteLine($"İlk değeri: {x}");
        Degistirici(ref x);
        Console.WriteLine($"Son değeri: {x}");


        //Out anahtar kelimesi:
        //Out, bir parametreye değer atamayı zorunlu kılar. Yani out kullanarak bir metodun parametresine
        //değer atamak, metodun içinde zorunludur. Out parametresi metodun dışında, yani metodun çağırıldığı 
        //yerden önce herhangi bir değere başlatılamk zorunda değildir. Out genellikle metodun çıkış değerine
        //dönmek için kullanılır.

        int y;
        Zorlayici(out y);
        Console.WriteLine($"Son değeri: {y}");

    }

    static void Degistirici(ref int x)
    {
        x = 30;
    }

    static void Zorlayici(out int y)
    {
        y = 0;
    }
}
