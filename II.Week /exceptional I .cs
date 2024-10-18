using System;


class Program
{
    static void Main()
    {
        /*
        * Hata ayıklamak için try ve catch blokları kullanılır try: dene catch: yakla anlamlarına gelir. catch fonksiyonu ile
        * hatayı yaklalarız try ile deneriz. try kullanılırsa kessinlikle catch fonkisyonu kullanılamk zorundadır.
        */

        try
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int deger = Convert.ToInt32(Console.ReadLine());

        }
        catch (FormatException ex)
        {
            /*
            * Ne işe yarar: Bu istisna, bir verinin beklenen formatta olmadığında meydana gelir.
            * Örneğin, kullanıcı bir sayıyı girmesi gerektiğinde, metin olarak harfler girerse bu hata fırlatılır.
            * Nerede kullanılır: Genellikle, kullanıcıdan alınan verilerin dönüştürülmesi sırasında kullanılır. 
            * Örneğin, Convert.ToInt32(giris) çağrıldığında ve giris değeri sayısal olmayan bir metin içeriyorsa,
            * FormatException fırlatılır.
            * Kullanılmadığı takdirde: Eğer bu hata yakalanmazsa, programın çökmesine yol açar 
            * ve kullanıcıya bir hata mesajı göstermeden çalışmayı durdurur.
            */

            /*
             * EX PARAMETRESİ: 
             * Yaklanan istisnanın bilgilerini içerir. Bu, hata hakkında daha fazla bilgi almak için
             * kullanılabilir. Örneğin, hata mesajını, hatanın türünü ve diğer özelliklerini elde etmek
             * için ex kullanılabilir.
             * 
             * 
             * istisna yaklarken bu şekilde kullanılabilir:
             * 
             * catch(FormatException ex){
             *          Console.WriteLine("Hata: " + ex.Message);
             * }
            */

            Console.WriteLine("Hata: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            /*
             * Ne İşe Yarar:
             * Bu istisna, bir değerin veri türünün alabileceği sınırları aştığında meydana gelir.
             * Örneğin, bir int türü için değeri 32-bit tamsayı sınırları dışına çıkarsa (örneğin,
             * Int32.MaxValue'dan daha büyük bir değer girişi), bu hata fırlatılır.
             * 
             * Nerelerde Kullanılır:
             * Yine, dönüşüm işlemleri sırasında kullanılır. Örneğin, büyük bir sayıyı int
             * türüne dönüştürmeye çalışırken bu istisna oluşabilir.
             * 
             * Kullanılmadığı Takdirde:
             * Eğer bu hata yakalanmazsa, program yine çöker ve kullanıcıya bir
             * hata mesajı göstermeden çalışmayı durdurur.
             */
            Console.WriteLine("Hata: " + ex.Message);

        }
        catch (Exception ex)
        {
            /*
             * Ne İşe Yarar:
             * Bu, tüm istisnaların üst sınıfıdır. Belirli bir hata türünü bilmediğiniz durumlarda
             * kullanılabilir. Programın beklenmedik bir durumla karşılaştığında hata vermesini önleyebilir.
             * 
             * Nerelerde Kullanılır:
             * Diğer spesifik hataları yakalamadıysanız, genel bir hata yakalamak için kullanılabilir.
             * 
             * Kullanılmadığı Takdirde:
             * Eğer genel bir hata yakalamazsanız, program belirli bir hata ile karşılaştığında çökebilir.
             */
             Console.WriteLine("Hata: " + ex.Message);
        }
    }   
}

