using System;

class GenelSinif<T> where T : new()
{
    public T Ozellik { get; set; }

    public void Metod(T deger)
    {
        T nesne = new T();
        Console.WriteLine("Çalıştı ! ");
    }
}
class Sinif
{

}

class Program
{
    static void Main()
    {
        GenelSinif<Sinif> yeni = new GenelSinif<Sinif>();
        yeni.Metod(new Sinif()); // Bu taraf tam olarak oturmadı hala hata yapıyorum
    }
}
