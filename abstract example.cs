using System;
using System.Reflection.Metadata.Ecma335;

public abstract class Otomobil
{
    public abstract string Name { get; set; }
    public abstract int ProductionOfYear { get; set; }

    public abstract void Price();
}

class Mercedes : Otomobil
{
    public override string Name { get; set; }
    public override int ProductionOfYear { get; set; }

    public Mercedes()
    {
        Name = "Mercedes A7";
        ProductionOfYear = 1999;
    }

    public override void Price()
    {
        int SalesPrice = ProductionOfYear * 1000;
        Console.WriteLine($"Price: {SalesPrice}");
    }
}
class Program
{
    static void Main()
    {
        Mercedes m = new Mercedes();
        m.Price();
    }
}
