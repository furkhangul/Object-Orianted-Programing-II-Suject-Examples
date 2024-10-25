using System;

class Program
{
    static void Main()
    {
        IHayvan[] hayvanlar = new IHayvan[]
{
            new Hamsi(),
            new Levrek(),
            new Papagan(),
            new Leylek(),
            new Timsah(),
            new Kaplumbaga()
};

        foreach (var hayvan in hayvanlar)
        {
            hayvan.Hareket();
        }
    }
}

interface IHayvan
{
    void Hareket();
}

class Balik : IHayvan
{
    public Balik()
    {

    }
    public void Hareket()
    {
        Console.WriteLine("Balık yüzüyor.");
    }
}

class Hamsi : Balik
{
    public Hamsi()
    {

    }
}

class Levrek : Balik
{
    public Levrek()
    {


    }
}

class Somon : Balik
{
    public Somon()
    {

    }
}


class Kus : IHayvan
{
    public int BacakSayisi {  get; set; }

    public Kus(int bacaksayisi)
    {
        this.BacakSayisi = bacaksayisi;
    }
    public void Hareket()
    {

    }
}

class Papagan : Kus
{
    
    public Papagan() : base(2)
    { 
 
    }
}

class Leylek : Kus
{
    public Leylek() : base(2) 
    {

    }
}

class Baykus : Kus
{
    public Baykus() : base(2)
    {

    }
}

class Surungen : IHayvan
{
    public Surungen() 
    {

    }
    public void Hareket()
    {

    }
}

class Timsah : Surungen
{
    public Timsah()
    {

    }
}

class Kaplumbaga : Surungen
{
    public Kaplumbaga()
    {

    }
}

class Yilan : Surungen
{
    public Yilan() 
    { 

    }
}

