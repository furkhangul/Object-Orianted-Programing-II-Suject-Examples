class Program
{
    public delegate double HesapMakinesi(double sayi1, double sayi2);
    static void Main()
    {
        Console.Write("1.sayı: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2.sayı: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("[1] Toplama İşlemi");
        Console.WriteLine("[2] Çıkarma İşlemi");
        Console.WriteLine("[3] Çarpma İşlemi");
        Console.WriteLine("[4] Bölme İşlemi");
        Console.Write("İŞLEM SEÇ: ");
        int secim = int.Parse(Console.ReadLine());
        HesapMakinesi hesap = null;
        if (secim == 1)
        {
            hesap = Topla;
        }
        else if (secim == 2)
        {
            hesap = Cikar;
        }
        else if (secim == 3)
        {
            hesap = Carp;
        }
        else if (secim == 4)
        {
            hesap = Bol;
        }


        for(int i =0; i < 3; i++)
        {
            Console.WriteLine("[1] Toplama İşlemi");
            Console.WriteLine("[2] Çıkarma İşlemi");
            Console.WriteLine("[3] Çarpma İşlemi");
            Console.WriteLine("[4] Bölme İşlemi");
            Console.Write("İŞLEM SEÇ: ");
            int secim2 = int.Parse(Console.ReadLine());
            if (secim2 == 1)
            {
                hesap += Topla;
            }
            else if (secim2 == 2)
            {
                hesap += Cikar;
            }
            else if (secim2 == 3)
            {
                hesap += Carp;
            }
            else if (secim2 == 4)
            {
                hesap += Bol;
            }

        }
        Delegate[] delegeler = hesap.GetInvocationList();
        foreach(var i in delegeler)
        {
            double sonuc = ((HesapMakinesi)i).Invoke(15, 45);
            Console.WriteLine(sonuc);
        }


    }

    static double Topla(double s1, double s2)
    {
        return s1 + s2;
    }

    static double Cikar(double s1, double s2)
    {
        if (s1 > s2)
        {
            return s1 - s2;
        }

        return s2 - s1;
    }

    static double Carp(double s1, double s2)
    {
        return s1 * s2;
    }

    static double Bol(double s1, double s2)
    {
        if (s1 > s2)
        {
            if (s1 != 0)
            {
                return s1 / s2;
            }
            else
            {
                Console.WriteLine("Bölüm 0 olamaz !");
            }
        }
        return s2 / s1;

    }
}
