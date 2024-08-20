using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main()
    {
        Square square = new Square();
        square.Area();
        Circle circle = new Circle();
        circle.Area();
    }
}

public abstract class Geomety
{ 
    public abstract int EdgeHeight { get; set; }
    public abstract int Radius { get; set; }
    public abstract void Area();
}

class Square : Geomety
{
    public override int EdgeHeight { get; set; }
    public override int Radius { get; set; }

    public Square()
    {
        Console.WriteLine("Please enter a edge height:");
        EdgeHeight = int.Parse(Console.ReadLine());
    }

    public override void Area()
    {
        int AreaTotal = EdgeHeight * EdgeHeight;
        Console.WriteLine("Area Total: {0}",AreaTotal);
    }
}

class Circle : Geomety
{
    public override int Radius { get; set; }
    public override int EdgeHeight { get; set; }

    public Circle()
    {
        Console.WriteLine("Please enter a radius:");
        Radius = int.Parse(Console.ReadLine());
    }
    public override void Area()
    {
        double totalAreaCircle = Radius * Radius * Math.PI;
        Console.WriteLine("Circle Area:{0}", totalAreaCircle);
    }

}
