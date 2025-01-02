using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
class Program
{
    //Bu bölümde thread kullanılması gerekiyor. Thread aynı zamanlı olarak programın birden
    //fazla iş yapmasını sağlar. Task'te kullanılabilir. 
    static void Main()
    {
        Thread a = new Thread(Method1);
        a.Start();
    }

    private static void Method1()
    {
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine("Çalışıyorum");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
