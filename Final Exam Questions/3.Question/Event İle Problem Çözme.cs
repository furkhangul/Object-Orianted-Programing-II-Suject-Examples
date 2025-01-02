using System;

class Program
{
    static void Main()
    {
        Otobus otobus = new Otobus();
        otobus.KisiGirdi();
        for(int i =0; i< 60; i++)
        {
            otobus.KisiGirdi();
        }
        otobus.KisiCikti();
    }
}

interface ITasit
{
    int KisiSayisi { get; set }
}

class Otobus : ITasit
{

    public event EventHandler EventDene;
    public int KisiSayisi { get; set; }

    public void KisiGirdi()
    {
        this.KisiSayisi++;
        if(KisiSayisi >= 50)
        {
            EventDene!.Invoke(this, EventArgs.Empty);
        }
    }

    public void KisiCikti()
    {
        this.KisiSayisi--;
    }
}
