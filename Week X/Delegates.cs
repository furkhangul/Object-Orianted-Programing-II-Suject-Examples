Dusing System;


class Delegete
{
    public delegate int MyDelegate(int number1 , int number2);
    static void Main()
    {
        HesapMakinesi hesap = new HesapMakinesi();
        MyDelegate delege = hesap.topa;
        Console.WriteLine(delege(15, 45));
        delege += hesap.cikar;
        Console.WriteLine(delege(15, 45));
        delege += hesap.carp;
        Console.WriteLine(delege(15, 45));
        delege += hesap.bolum;
        Console.WriteLine(delege(15, 45));



    }
}


public class HesapMakinesi
{
    public int topa(int x , int y)
    {
        return x + y;
    }
    public int cikar(int x, int y)
    {
        if (x >= y)
        {
            return x - y;
        }
        else
        {
            return y - x;
        }
    }
    public int carp(int x, int y)
    {
        return x * y;
    }

    public int bolum(int x, int y)
    {
        if(x >= y)
        {
            return x / y;
        }
        else
        {
            return y / x;
        }
    }
}
