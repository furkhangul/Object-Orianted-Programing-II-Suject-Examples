using System;


class Program
{
    static void Main()
    {
        Square total = new Square();
        total.Area();

    }
}

public abstract class Geomety
{ 
    public abstract int EdgeHeight { get; set; }
    public abstract void Area();
}

class Square : Geomety
{
    public override int EdgeHeight { get; set; }

    public Square()
    {
        EdgeHeight = 5;
    }

    public override void Area()
    {
        int AreaTotal = EdgeHeight * EdgeHeight;
        Console.WriteLine("Area Total: {0}",AreaTotal);
    }
}
