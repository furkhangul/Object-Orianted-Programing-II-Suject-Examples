using System;

class Program
{
    //out, bir metotla dışarıya veri aktarmak için kullanılır ve metoda giren değişkene içeride mutlaka bir değer atanmalıdır.
    static void Main()
    {
        int x;
        OutKullanimi(out x);
        Console.WriteLine(x);

    }
    static void OutKullanimi( out int x)
    {
        x = 2;
    }
}

