using System;

class Program
{
    static void Main()
    {

        /*
           Dizi (Array) elemanlarına erişim ve istisna yönetimi:
         - 4 elemanlı bir mühendis isimleri dizisi tanımlayın.
         - Kullanıcıdan dizideki mühendislerden birini seçmesi için indeks numarası alın.
         - Kullanıcının girdiği indeks numarasına göre ilgili mühendis ismini ekrana yazdırın.
         - Kullanıcının geçersiz bir indeks girmesi durumunda istisna yakalayın.
        */

        string[] muhendis = new string[4];
        muhendis[0] = "Furkan Gül";
        muhendis[1] = "Fırat Dik";
        muhendis[2] = "Süleyman Büdün";
        muhendis[3] = "Samet Aslan";

        while (true) 
        {
            try
            {
                Console.Write("Mühendis No (0-3): ");
                int no = Convert.ToInt32(Console.ReadLine());
                if (no < 0 || no > 3)
                {
                    throw new IndexOutOfRangeException("Girilen sayı mühendisler arasında bulunmamaktadır!");
                }

                Console.WriteLine("Aradığınız mühendis: {0}", muhendis[no]);
                break;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Girdiğiniz değerin format hatası bulunmaktadır !");
                Console.WriteLine("Hata Açıklaması: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Girilen sayı mühendisler arasında bulunmamaktadır!");
                Console.WriteLine("Hata Açıklaması: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Girdiğiniz kodda farklı bir hata tespit edildi !");
                Console.WriteLine("Hata Açıklaması: " + ex.Message);
            }
            
            finally
            {
                Console.WriteLine("Program çalışmaya devam ediyor...");
            }
            
        }

        Console.WriteLine("Program başarılı bir şekilde sonlandırıldı!");
    }
}
