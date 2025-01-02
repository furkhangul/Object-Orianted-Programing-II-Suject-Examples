using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread T = new Thread(Method1);
        T.Start();
    }
    private static void Method1()
    {
        for(int i = 0; i < 100; i++)
        {
            Console.WriteLine("ÇALIŞIYOR !");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
