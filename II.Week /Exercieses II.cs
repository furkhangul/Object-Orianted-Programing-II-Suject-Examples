using System;


class Program
{
    static void Main()
    {
        //Soru 2 //
        /*
         * Yaş girişinin `byte` veri türüne dönüştürülmesi ve istisnaların yönetilmesi:
         * Kullanıcıdan yaşını girmesini isteyin.
         * Yaşı `byte` veri türüne dönüştürmeye çalışın.
         * Aşağıdaki istisnaları yakalayın:
         * `OverflowException`: Kullanıcı `byte` sınırlarını aşan bir sayı girdiğinde yakalayın.
         * Diğer tüm hataları yakalamak için genel bir `Exception` kullanın.
         */

        try
        {
            Console.Write("Yaşınızı giriniz: ");
            byte yas = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Girdiğiniz yaş başarılı bir şekilde sisteme eklendi ! ");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Yaşınız byte veri tipinden daha büyük !");
            Console.WriteLine("Hata açıklaması: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Lütfen girdiğiniz karakteri sayı tipinde giriniz !");
            Console.WriteLine("Hata açıklaması: " + ex.Message);
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Farklı bir hata tespit edildi ! ");
            Console.WriteLine("Hata açıklaması: " + ex.Message);
        }
    }
}
