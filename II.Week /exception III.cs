using System;


class Exceptions
{
    static void Main()
    {
        string[] muhendisler = new string[5];
        muhendisler[0] = "Furkan Gül";
        muhendisler[1] = "Samet Dik";
        muhendisler[2] = "Fırat Aslantaş";
        muhendisler[3] = "Süleyman Sherifow";
        muhendisler[4] = "Deniz Büdün";
        try
        {
            Console.Write("Mühendis No: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aradığnız mühendis: {0}", muhendisler[no]);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata :" + ex.Message);
        }

    } 
}
