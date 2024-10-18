using System;

class Exceptions
{
    static void Main()
    {
        try
        {
            Console.Write("Yaşınızı giriniz:");
            byte yas = byte.Parse(Console.ReadLine());

            Console.WriteLine("Yaşınız başarılı bir şekilde sisteme aktarıldı !\nYaşınız: {0}", yas);

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Byte türünün dışında farklı bir karakter girdiniz bunu için lütfen doğru karakteri giriniz ! ");
        }

        catch (OverflowException ex)
        {
            Console.WriteLine("Byte türünün dışında farklı bir uzunlukta sayı girdiniz !");
        }

        catch (Exception)
        {
            Console.WriteLine("Farklı bir hata tespit edildi !");
        }

    }

    
}
