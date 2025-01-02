using System;
using System.Collections.Generic;

class GenelSinif<T> where T : new()
{
    public T Ozellik { get; set; }

    public void Metot(T Ozellik)
    {
        T nesne = new T();
        Console.WriteLine("Metod Çalıştı !");
    }
}

class Sinif
{

}

class Program
{
    static void Main()
    {
        GenelSinif<Sinif> genelSinif = new GenelSinif<Sinif>();
        genelSinif.Metot(new Sinif());
    }
}
