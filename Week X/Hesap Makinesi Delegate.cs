using System;
using System.Runtime;
using System.Security.Cryptography;

class HesapMakinesi
{
    public delegate  double Temsilci(double s1, double s2);
    static void Main()
    {
        Console.Write("1. sayıyı gir: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2. sayıyı gir: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("[1] Toplama");
        Console.WriteLine("[2] Çıkarma");
        Console.WriteLine("[3] Çarpma");
        Console.WriteLine("[4] Bölme");
        Console.Write("Lütfen bir mod seçin: ");
        int mod = int.Parse(Console.ReadLine());
        Temsilci hesap = null; // Başlamadan önce delegatemizi boşa aldık.
        switch (mod)
        {
            case 0:
                hesap = new Temsilci(Topla);
                break;
            case 1:
                hesap = new Temsilci(Cikar);
                break;
            case 2:
                hesap = new Temsilci(Carp);
                break;
            case 3:
                hesap = new Temsilci(Bol);
                break;
            default:
                Console.WriteLine("Lütfen geçerli bir mod seçiniz !");
                break;
        }
        double sonuc = hesap(sayi1,sayi2);
        Console.WriteLine($"Sonuç: {sonuc}");
    }
    static double Topla(double s1, double s2)
    {
        return s1 + s2;
    }
    static double Cikar(double s1, double s2)
    {
        if(s2 < s1)
        {
            return s1 - s2;
        }
        else
        {
            return s2 - s1;
        }
    }
    static double Carp(double s1, double s2)
    {
        return s1 * s2;
    }
    static double Bol(double s1, double s2)
    {
        if (s2 == 0)
        {
            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz!");
            return double.NaN;
        }
        return s1 / s2;
    }
}
