
//Bölümden kalan ve böl isminde 2 metot tanımla.
//Bu fonksiyon dışardan 2 tane double değişken olacak ve geriye double tipinde değer döndürecek.
//Bir delegate tanımla. Bu 2 metodu delegate içine ekle.
//Sonra main metodunda delegatei 2 adet double değişken ile çağırdığında metotlardan dönen değerler değişkene alınıp ekranda  " Bölüm sonucu " ve " Kalan" ekrana yaz.
//Metot içinde ekrana yazılmayacak olan kodu yazınız.
using System;
class Program
{
    static double BolumdenKalan(double sayi1, double sayi2)
    {
        return sayi1 % sayi2;
    }

    static double Bol(double sayi1, double sayi2)
    {
        return sayi1 / sayi2 ;
    }
    public delegate double Delege(double sayi1, double sayi2);
    static void Main()
    {
        Console.Write("Bölünecek sayı: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Bölecek sayı: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Delege delege1 = Bol;
        delege1 += BolumdenKalan;

        Delegate[] temsilci = delege1.GetInvocationList();
        double bolumsonucu = ((Delege)temsilci[0]).Invoke(sayi1,sayi2);
        Console.WriteLine("Bölüm sonucu değeri: {0}", bolumsonucu);
        double kalansonuc = ((Delege)temsilci[1]).Invoke(sayi1, sayi2);
        Console.WriteLine("Bölümden kalan değer: {0}", kalansonuc);

    }
}
