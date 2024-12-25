using System;

class Program
{
    //ref, bir metot parametresinin referans olarak aktarılmasını sağlar, böylece metoda gönderilen değişken üzerinde yapılan değişiklikler doğrudan orijinal değişkene yansır.
    static void Main()
    {
        int x = 10;
        degis(ref x);
        Console.WriteLine(x);

    }
    static void degis( ref int x)
    {
        x = 2;
    }
}

