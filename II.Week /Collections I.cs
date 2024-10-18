
// 18.10.2024 -- Cuma saat 15.13 :)
// Aslında ben de isterim düşünmeden konuşmayı, küçük bir oyunda önemli kişi olmayı.

using System;

class Collections
{
    static void Main()
    {
        //Bu derste koleksiyonların bütün çeşitlerini ve nasıl kullanıldıklarını öğrendim.

        try
        {
            Console.WriteLine("[0] Ana Sayfa");
            Console.WriteLine("[1] Arrays");
            Console.WriteLine("[2] List");
            Console.WriteLine("[3] Dictionary");
            Console.Write("Koeleksiyon türünü seç:");
            int mod = int.Parse(Console.ReadLine());
            if (mod == 0)
            {
                Console.Clear();
                Main();
            }
            else if (mod == 1)
            {
                Console.Clear();
                arrayss();
                Console.ReadLine();
                Console.Clear();
                Main();

            }
            else if (mod == 2)
            {
                Console.Clear();
                listss();
                Console.ReadLine();
                Console.Clear();
                Main();

            }
            else if (mod == 3)
            {
                dictionaryss();
                Console.ReadLine();
                Console.Clear();
                Main();
            }
            else if (mod == 4)
            {
                Console.Clear();
                arrayss();
                Console.ReadLine();
                Console.Clear();
                Main();
            }
            else if (mod == 5)
            {
                Console.Clear();
                arrayss();
                Console.ReadLine();
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir koleksiyon seçiniz !");
            }

        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hatanız: " + ex.Message);
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Hatanız: " + ex.Message);
            Console.ReadLine();
            Console.Clear();
            Main();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Hatanız: " + ex.Message);
            Console.ReadLine();
            Console.Clear();
            Main();
        }
    }

    static void arrayss()
    {


        /*
         *Diziler:
         *Sabit boyutludur, oluşturulduktan sonra boyut değiştirilemez.
         *Hızlı erişim sağlar. İndex ile doğrdan elemanlara erişiriz.
         */

        Console.Write("Dizinin uzunluğunu belirleyiniz: ");
        int uzunluk = int.Parse(Console.ReadLine());
        int[] dizi = new int[uzunluk];
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write($"{i + 1}.terimi giriniz: ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Girdiğiniz Dizi:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine($"{i + 1}.sayınız: {dizi[i]}");
        }


    }
    static void listss()
    {
        List<int> list = new List<int>();
        while (true)
        {
            Console.Write("Listeye eklemek istiyor musun(y/n):");
            string yn = Console.ReadLine();
            if(yn == "y" )
            {
                Console.Clear();
                Console.Write("Sayı ekle: ");
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
                Console.Clear() ;
            }
            else
            {
                break;
            }
        }
        Console.Clear();
        Console.WriteLine("Liste Elemanları");
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
    static void dictionaryss()
    {

        /*
         * Özellikler:
         * Anahtar-değer çiftleri ile çalışır. Anahtarlar benzersiz olmalıdır.
         * Hızlı erişim ve güncelleme sağlar.
         * 
         * Kullanımı:
         * Dictionary<string, int> yaslar = new Dictionary<string, int>();
         * yaslar["Ahmet"] = 30;
         * yaslar["Mehmet"] = 25;
         * int ahmetYasi = yaslar["Ahmet"]; // Anahtar ile erişim
         * 
         * Anahtar Kontrolü:
         * if (yaslar.ContainsKey("Mehmet"))
         * {
         * Console.WriteLine("Mehmet'in yaşı: " + yaslar["Mehmet"]);
         * }
         */
        Console.WriteLine("[0] Ana Sayfa");
        Console.WriteLine("[1] Kullanıcı depolama");
        int mod = int.Parse(Console.ReadLine());
        if(mod == 0)
        {
            Console.Clear ();
            Main();
        }
        else if (mod == 1) 
        {
            Console.Clear ();
            usermanagement();
            Console.ReadLine();
            Console.Clear () ;
            Main();
        }
    }
    static void usermanagement()
    {
        // Kullanıcı bilgilerini depolamak için bir Dictionary oluşturma
        Dictionary<string, int> user = new Dictionary<string, int>();

        // Kullanıcı ekleme
        user.Add("Furkan", 123);
        user.Add("Fırat", 124);

        // Kullanıcı ekleme ve hata kontrolü
        AddUser(user, "Ayşe", 125);
        AddUser(user, "Furkan", 126); // Aynı anahtarı eklemeye çalışacak

        // Kullanıcı bilgilerini yazdırma
        PrintUsers(user);

        // Kullanıcının puanını güncelleme
        UpdateUserScore(user, "Fırat", 130);

        // Kullanıcı bilgilerini tekrar yazdırma
        PrintUsers(user);
    }

    static void AddUser(Dictionary<string, int> user, string name, int score)
    {
        if (!user.ContainsKey(name))
        {
            user.Add(name, score);
            Console.WriteLine($"{name} başarıyla eklendi.");
        }
        else
        {
            Console.WriteLine($"{name} zaten mevcut.");
        }
    }

    static void UpdateUserScore(Dictionary<string, int> user, string name, int newScore)
    {
        if (user.ContainsKey(name))
        {
            user[name] = newScore;
            Console.WriteLine($"{name}'ın puanı {newScore} olarak güncellendi.");
        }
        else
        {
            Console.WriteLine($"{name} bulunamadı.");
        }
    }

    static void PrintUsers(Dictionary<string, int> user)
    {
        Console.WriteLine("Kullanıcılar ve Puanları:");
        foreach (var kvp in user)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine();
    }
}
