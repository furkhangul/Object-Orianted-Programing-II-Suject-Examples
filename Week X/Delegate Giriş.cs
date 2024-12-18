using System;

class Program
{
    public delegate void Temsilci();
    static void Main()
    {
        Temsilci T = new Temsilci(Zipla);
        T += Ates;
        T += Can;
        T += Ilerle;

        T.Invoke(); // Delegatelerin birden fazla şeyi üst üste yapmasını sağlıyor
        //pek bi işe yaramıyor.
    }   
    static void Zipla()
    {
        Console.WriteLine("Oyuncu şu an zıplıyor !");
    }
    static void Ates()
    {
        Console.WriteLine("Oyuncu şu an ateş ediyor !");

    }
    static void Can()
    {
        Console.WriteLine("Oyuncu şu an can topluyor !");

    }
    static void Ilerle()
    {
        Console.WriteLine("Oyuncu şu an ilerliyor !");
    }
}
