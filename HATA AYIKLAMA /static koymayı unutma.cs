using System;

// yeni açtığım methodları da static yapmadığı için kod hata veriyor static olması gerkiyor.
class Program
{
    public static double BolumdenKalan(double bolen, double bolunen)
    {
        return bolunen % bolen;
    }

    public static double Bol(double bolen, double bolunen)
    {
        if(bolunen == 0)
        {
            Console.Write("Bölünen değer 0 olamaz !");
            return 0;
        }
        else
        {
            return bolunen / bolen;
        }
    }

    public delegate  double Delege(double bolen, double bolunen);

    static void Main()
    {
        Delege newdelege;
        newdelege = Bol;
        newdelege += BolumdenKalan;

        Delegate[] temsilci = newdelege.GetInvocationList();

        double bolSonucu = ((Delege)temsilci[0]).Invoke(3, 15);
        Console.WriteLine("Bolumun sonucu : {0}", bolSonucu);
        double kalansonucu = ((Delege)temsilci[1]).Invoke(3, 15);
        Console.WriteLine("Bolum sonucu kalan değeri: {0}", kalansonucu);
    }
}
