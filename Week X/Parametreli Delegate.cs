using System;

class Program
{
    public delegate double HesapMakinesi(double sayi1, double sayi2);
    static void Main()
    {
        Console.Write("Lütfen 1. sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lütfen 2. sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());


        HesapMakinesi hesap = Topla;
        hesap += Cikar;
        hesap += Carp;
        hesap += Bol;


        Delegate[] temsilciler = hesap.GetInvocationList();

        foreach(var i in temsilciler)
        {
            double sonuc = ((HesapMakinesi)i).Invoke(sayi1, sayi2);
            Console.WriteLine(sonuc);
        }

    }
    static double Topla(double s1, double s2)
    {
        return s1 + s2;
    }
    static double Cikar(double s1, double s2)
    {
        if (s1 < s2)
        {
            return s2 - s1;
        }
        return s1 - s2;
    }
    static double Carp(double s1, double s2)
    {
        return s1 * s2;
    }
    static double Bol(double s1, double s2)
    {
        if (s1 < s2)
        {
            if (s1 != 0)
            {
                return s2 / s1;
            }
            else
            {
                Console.WriteLine("Bölme tanımsızdır !");
            }
        }

        return s1 / s2;
    }
}
