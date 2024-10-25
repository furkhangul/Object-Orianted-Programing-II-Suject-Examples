using System;


class Program
{
    static void Main()
    {
        Dikdortgen dikdorgen = new Dikdortgen(5,8);
        dikdorgen.AlanHesapla();
        Kare yenikare = new Kare(5, 5);
        yenikare.AlanHesapla();

    }
}

public abstract class Dortgen
{
    protected int A { get; set; }
    protected int B { get; set; }

    public Dortgen(int a, int b)
    {
        this.A = a;
        this.B = b;
    }
    protected void AlanHesapla()
    {
        Console.WriteLine("Alan: {0}", A * B);
    }
}
public class Dikdortgen : Dortgen
{
    public  Dikdortgen(int a , int b) : base(a, b)
    {

    }
    public  void AlanHesapla()
    {
        Console.WriteLine("Dikdörtgenin Alanı: " + A * B);
    }
}

public class Kare : Dortgen
{
    public Kare(int a,int b ) : base(a,b)
    {

    }

    public void AlanHesapla()
    {
        Console.WriteLine("Karenin Alanı: " + A * B);
    }

}
