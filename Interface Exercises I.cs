using System;
using System.Globalization;


class Program
{
    static void Main()
    {

    }
}


interface IUser
{

    int Id { get; set; }
    string Name { get; set; }
    string Surname {  get; set; }
    
}
class Administrator : IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}
    class Guest : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

