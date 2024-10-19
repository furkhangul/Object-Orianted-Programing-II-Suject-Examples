using System;


class Program
{
    static void Main()
    {
        //Soru 1 //
        /*
        Bir tam sayı (integer) girişinin istisna yönetimi ile kontrol edilmesi:
        - Kullanıcıdan bir tam sayı değeri alın.
        - Alınan değeri tam sayıya dönüştürmeye çalışın.
        - Aşağıdaki istisnaları yakalayın:
        - `FormatException`: Kullanıcı tam sayı yerine geçersiz bir giriş yaparsa yakalayın.
        - `OverflowException`: Kullanıcı çok büyük veya çok küçük bir tam sayı girdiğinde yakalayın.
        - İstisnalar yakalandığında uygun bir hata mesajı gösterin.  
         */


        try
        {
            Console.Write("Sayı giriniz:");
            int deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz {0} sayısı başarılı bir şekilde sisteme eklendi.", deger);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Girilen sayı gereğinden fazla veya girlmesi gerekenden küçük bir sayı !");
            Console.WriteLine("Hata Açıklaması: " + ex.Message);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Girdiğiniz değerin format hatası bulunmaktadır !");
            Console.WriteLine("Hata Açıklaması: " + ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Girdiğiniz kodda farklı bir hata tespit edildi !");
            Console.WriteLine("Hata Açıklaması: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program başarılı bir şekilde sonlandırıldı ! ");
        }
    }
}
