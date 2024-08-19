using Microsoft.VisualBasic.FileIO;
using System;

class Program
{
    static List<Book> BookList = new List<Book>();
    static List<User> UserList = new List<User>();
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome To Libery. Please select a mode.");
        Console.WriteLine("[1] Add Book ");
        Console.WriteLine("[2] Add User ");
        Console.WriteLine("[3] List Book ");
        Console.WriteLine("[4] List User ");
        Console.WriteLine("[5] Take A Book");
        Console.WriteLine("[6] Return a Book");
        Console.Write("mode:");
        int mode = int.Parse(Console.ReadLine());
        switch (mode)
        {
            case 1:
                Console.Clear();
                AddBook();
                break;
            case 2:
                Console.Clear();
                AddUser();
                break;
            case 3:
                ListBook();
                break;
            case 4:
                ListUser();
                break;
            case 5:
                Console.Clear();
                TakeBook();
                break;
            case 6:
                ReturnBook();
                break;
            default:
                Main();
                break;
        }
        Console.ReadLine();
    }
    static void AddBook()
    {
        Console.Write("IDSN:");
        int idsn = int.Parse(Console.ReadLine());
        Console.Write("Book Name:");
        string bookname = Console.ReadLine();
        Console.Write("Writer:");
        string writer = Console.ReadLine();
        Console.Write("Book Out Year:");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Book Topic:");
        string topic = Console.ReadLine();
        Console.Write("Avaliable(available / not available):");
        string put = Console.ReadLine();
        bool avaliable;
        if (put == "true" || put == "avaliable")
        {
            avaliable = true;
        }
        else if (put == "false" || put == "not avaliable")
        {
            avaliable = false;
        }
        else
        {
            avaliable = false;
        }
        Book newbook = new Book(idsn, bookname, writer, year, topic, avaliable);
        BookList.Add(newbook);
        Main();
    }
    static void AddUser()
    {
        Console.Write("ID:");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("Surname:");
        string surname = Console.ReadLine();
        Console.Write("Age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Email Adress:");
        string email = Console.ReadLine();
        string received = "";

        User newuser = new User(id, name, surname, age, email, received);
        UserList.Add(newuser);
        Main();
    }
    static void ListBook()
    {
        Console.Clear();
        foreach (Book book in BookList)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Book ISDN:{0}", book.IDSN);
            Console.WriteLine("Book Name:{0}", book.BookName);
            Console.WriteLine("Book Writer:{0}", book.Writer);
            Console.WriteLine("Book Out Year:{0}", book.Year);
            Console.WriteLine("Book Topic:{0}", book.Topic);
            Console.WriteLine("-----------------------------------------------");
        }
        Console.ReadLine();
        Main();
    }
    static void ListUser()
    {
        Console.Clear();
        foreach (User user in UserList)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("User ID:{0}", user.ID);
            Console.WriteLine("User Name:{0}", user.Name);
            Console.WriteLine("User Surname:{0}", user.Surname);
            Console.WriteLine("User Age:{0}", user.Age);
            Console.WriteLine("User Email:{0}", user.Email);
            Console.WriteLine("User Received:{0}", user.Received);
            Console.WriteLine("-----------------------------------------------");
        }
        Console.ReadLine();
        Main();
    }
    static void TakeBook()
    {
        Console.WriteLine("Who Want To Take(id):");
        int userId = int.Parse(Console.ReadLine());
        Console.WriteLine("Which Book is Want To Take(idsn):");
        int bookIdsn = int.Parse(Console.ReadLine());
        int idsninfo;
        string bookname0;
        int idinfo;
        foreach (Book book in BookList)
        {
            if (book.IDSN == bookIdsn)
            {
                if (book.Avaliable == true)
                {
                    Console.WriteLine("Book is avaliable !");
                    idsninfo = book.IDSN;
                    foreach (User user in UserList)
                    {
                        if (user.ID == userId)
                        {
                            Console.WriteLine("User Found !");

                            user.Received = user.Received + book.BookName + ", ";
                            Console.ReadLine();
                            Main();
                        }
                        else
                        {
                            Console.WriteLine("User not Found !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Book isn't avaliable !");
                }
            }
        }

    }
    static void ReturnBook()
    {
        Console.WriteLine("Who want to return book:");
        int returnid = int.Parse(Console.ReadLine());
        Console.WriteLine("Which book want to return:");
        int returnidsn = int.Parse(Console.ReadLine());
        foreach (Book book in BookList)
        {
            if ((book.IDSN == returnidsn))
            {
                book.Avaliable = true;
                foreach (User user in UserList)
                {
                    if (user.ID == returnid)
                    {
                        user.Received = "";
                    }
                }
            }

        }
    }

    class Book
    {
        public int IDSN { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public int Year { get; set; }
        public string Topic { get; set; }
        public bool Avaliable { get; set; }

        public Book(int idsn, string bookname, string writer, int year, string topic, bool avaliable)
        {
            IDSN = idsn;
            BookName = bookname;
            Writer = writer;
            Year = year;
            Topic = topic;
            Avaliable = avaliable;
        }
    }
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Received { get; set; }

        public User(int id, string name, string surname, int age, string email, string received)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Received = received;
        }
    } }
