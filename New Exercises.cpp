using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static List<Book> Books = new List<Book>();
    static List<User> Users = new List<User>();
    static void Main()
    {
        Mod();
    }
    static void Mod()
    {
        Console.WriteLine("[0] Home Page");
        Console.WriteLine("[1] Add Book");
        Console.WriteLine("[2] Add User");
        Console.WriteLine("[3] List Book");
        Console.WriteLine("[4] List User");
        Console.WriteLine("[5] Borrow a Book");
        Console.WriteLine("[6] Return the Book");
        Console.Write("Please chose a mode : ");
        int mode = int.Parse(Console.ReadLine());
        switch (mode)
        {
            case 0:
                Console.Clear();
                Main();
                break;
            case 1:
                Console.Clear();
                AddBook();
                Console.Clear();
                Mod();
                break;
            case 2:
                Console.Clear();
                AddUser();
                Console.Clear();
                Mod();
                break;
            case 3:
                Console.Clear();
                ListBook();
                Console.ReadLine();
                Console.Clear();
                Mod();
                break;
            case 4:
                Console.Clear();
                ListUser();
                Console.ReadLine();
                Console.Clear();
                Mod();
                break;
            case 5:
                Console.Clear();
                BorrowBook();
                Console.Clear();
                Mod();
                break;
            case 6:
                Console.Clear();
                ReturnBook();
                Console.Clear();
                Mod();
                break;
            default:
                Console.Write("Wrong Mode ! Please select valid mode ! ");
                break;
        }


    }
    static void AddBook()
    {
        Console.WriteLine("Welcome To Add Book Page");
        Console.Write("Enter Book IDSN: ");
        int idsn = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Book Name:");
        string bookname = Console.ReadLine();
        Console.Write("Enter Book Writer:");
        string writer = Console.ReadLine();
        Console.Write("Enter Book Publication Year:");
        int publicationyer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("It is Avaliable (true / false) : ");
        string bookavaliablestring = Console.ReadLine();
        bool bookavaliable;
        if (bookavaliablestring == "True" || bookavaliablestring == "T" || bookavaliablestring == "true" || bookavaliablestring == "t")
        {
            bookavaliable = true;
        }
        else
        {
            bookavaliable = false;
        }

        Book book = new Book(idsn, bookname, writer, publicationyer, bookavaliable);
        Books.Add(book);

    }
    static void AddUser()
    {
        Console.WriteLine("Welcome To Add User Page");
        Console.Write("Enter User ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter User Name:");
        string username = Console.ReadLine();
        Console.Write("Enter User Surname:");
        string lastname = Console.ReadLine();
        Console.Write("Enter User Birthday Year:");
        int birthyear = Convert.ToInt32(Console.ReadLine());
        string registeredbook = "";

        User user = new User(id, username, lastname, birthyear, registeredbook);
        Users.Add(user);
    }
    static void ListBook()
    {
        Console.WriteLine("Library Books");
        foreach (Book book in Books)
        {
            Console.WriteLine("Book IDSN: {0}", book.IDSN);
            Console.WriteLine("Book Name: {0}", book.BookName);
            Console.WriteLine("Book Writer: {0}", book.Writer);
            Console.WriteLine("Book Publication Year: {0}", book.PublicationDate);
            Console.WriteLine("Book is Avaliable: {0}", book.BookAvaliable);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
        }

    }
    static void ListUser()
    {
        Console.WriteLine("Library Users");
        foreach (User user in Users)
        {
            Console.WriteLine("User ID: {0}", user.ID);
            Console.WriteLine("User Name: {0}", user.UserName);
            Console.WriteLine("User Surname: {0}", user.Lastname);
            Console.WriteLine("User Birthday Year: {0}", user.BirthYear);
            Console.WriteLine("User Registered Book: {0} ", user.RegisteredBook);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");
        }
    }
    static void BorrowBook()
    {
        Console.WriteLine("Welcome to Borrow Book Page");
        Console.WriteLine("Enter your user ID:");
        int userid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your want to borrow book IDSN:");
        int bookidsn = Convert.ToInt32(Console.ReadLine());

        foreach (Book book in Books)
        {
            if (book.IDSN == bookidsn)
            {
                if (book.BookAvaliable)
                {

                    foreach (User user in Users)
                    {
                        if (user.ID == userid)
                        {
                            user.RegisteredBook = user.RegisteredBook + book.BookName + ", ";
                            book.BookAvaliable = false;
                            Console.WriteLine("Book added your registered !");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Book is not avaliable");
                }
            }

        }

    }
    static void ReturnBook()
    {
        Console.WriteLine("Welcome to Return Book");
        Console.Write("Enter your User ID: ");
        if (!int.TryParse(Console.ReadLine(), out int userid))
        {
            Console.WriteLine("Invalid User ID.");
            return;
        }

        Console.Write("Enter your return book IDSN: ");
        if (!int.TryParse(Console.ReadLine(), out int bookidsn))
        {
            Console.WriteLine("Invalid Book ID.");
            return;
        }

        bool bookFound = false;
        bool userFound = false;

        foreach (Book book in Books)
        {
            if (book.IDSN == bookidsn)
            {
                bookFound = true;
                foreach (User user in Users)
                {
                    if (user.ID == userid)
                    {
                        userFound = true;
                        book.BookAvaliable = true;
                        Console.WriteLine("Book has been successfully returned!");
                        user.RegisteredBook = user.RegisteredBook.Replace(book.BookName + ", ", "");
                        break;
                    }
                }
                break;
            }
        }

        if (!bookFound)
        {
            Console.WriteLine("Book not found.");
        }
        else if (!userFound)
        {
            Console.WriteLine("User not found.");
        }
    }



    class Book
    {

        public int IDSN { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public int PublicationDate { get; set; }
        public bool BookAvaliable { get; set; }

        public Book(int idsn, string bookname, string writer, int publicationdate, bool bookavaliable)
        {
            IDSN = idsn;
            BookName = bookname;
            Writer = writer;
            PublicationDate = publicationdate;
            BookAvaliable = bookavaliable;
        }
    }

    class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Lastname { get; set; }
        public int BirthYear { get; set; }
        public string RegisteredBook { get; set; }
        public User(int id, string username, string lastname, int birthyear, string registeredbook)
        {
            ID = id;
            UserName = username;
            Lastname = lastname;
            BirthYear = birthyear;
            RegisteredBook = registeredbook;
        }
    }
}
