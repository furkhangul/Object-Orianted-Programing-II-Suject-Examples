using System;

interface ITasit
{
    int KisiSayisi { get; set; }
}

class Otobus : ITasit
{
    public int KisiSayisi { get; set; }
    public event EventHandler KisiSayisiEvent; // bu bölüm de çok önemli
    public void KisiGirdi()
    {
        this.KisiSayisi++;
        if (KisiSayisi >= 50)
        {
            Console.WriteLine("50 Sınırı !");
            KisiSayisiEvent?.Invoke(this, EventArgs.Empty); // Kessinlikle bu kısmı ezberlememiz lazım unutma ! 
        }
    }

    public void KisiCikti()
    {
        this.KisiSayisi--;
    }
}
class Program
{
    static void Main()
    {
        Otobus otobus = new Otobus();
        otobus.KisiGirdi();
        for (int i = 0; i < 100; i++)
        {
            otobus.KisiGirdi();
        }
    }
}
