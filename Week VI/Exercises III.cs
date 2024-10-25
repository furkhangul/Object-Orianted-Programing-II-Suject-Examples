using System;

class Program
{
    static void Main()
    {
        Isci yeniisci = new Isci("Furkan Gül","Siirt");
        yeniisci.Bilgi();
        Console.WriteLine("İsim/Soyisim: "+ yeniisci.AdSoyad);
        Console.WriteLine("Adres: "+ yeniisci.Adres);
        Yonetici yeniyonetici = new Yonetici("Kerem Akdoğan","Ankara");
        yeniyonetici.Bilgi();
        Console.WriteLine("İsim/Soyisim: " + yeniyonetici.AdSoyad);
        Console.WriteLine("Adres: " + yeniyonetici.Adres);
    }
}

interface Ikisi
{
    string AdSoyad { get; set; }
    string Adres { get; set; }
    void Bilgi();
}
class Isci : Ikisi
{
    public string AdSoyad { get; set; }
    public string Adres { get; set; }

    public Isci(string adsoyad, string adres) 
    {
        this.AdSoyad = adsoyad; 
        this.Adres = adres;

    }
    public void Bilgi()
    {
        Console.WriteLine("Bu moethod işçi sınıfını temsil eder !");
    }
    public void Calis()
    {

    }
}

class Yonetici : Ikisi
{
    public string AdSoyad { get; set; }
    public string Adres { get; set; }

    public Yonetici(string adSoyad, string adres)
    {
        this.AdSoyad = adSoyad;
        this.Adres = adres;
    }

    public void Bilgi() 
    {
        Console.WriteLine("Bu method yönetici sınıfını temsil eder ! ");
    }
    public void Denetle()
    {

    }
}
