using System;
using System.Numerics;

class Program
{
    static double BolumdenKalan(double sayi1, double sayi2)
    {
        return sayi1 % sayi2;
    }
    static double Bol(double sayi1, double sayi2)
    {
        if (sayi1 == 0)
        {
            Console.WriteLine("Geçersiz giriş ! ");
            return 0;
        }
        else
        {
            return sayi1 / sayi2;
        }
    }
    public delegate double Delege(double sayi1, double sayi2);
    static void Main()
    {
        Delege delegeler = Bol;
        delegeler += BolumdenKalan;

        Delegate[] temsilci = delegeler.GetInvocationList();
        double bolumSonuc = ((Delege)temsilci[0]).Invoke(15,3);
        Console.WriteLine("Bölüm sonucu: {0}",bolumSonuc);
        double bolumdenkalansonuc = ((Delege)temsilci[1]).Invoke(15, 3);
        Console.WriteLine("Bölüm sonucu kalan değer: {0}",bolumdenkalansonuc);

    }
}
