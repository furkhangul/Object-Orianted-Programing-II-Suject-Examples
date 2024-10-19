using System;
using System.Collections;
using System.Collections.Specialized;
using System.Reflection;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Add fonksiyonu bir koleksiyona yeni bir nesne eklenmesinde kullanılır.
        ArrayList arrayList = new ArrayList();
        arrayList.Add("Muz");
        arrayList.Add(12);
        arrayList.Add("Çilek");

        // AddRange fonksiyonu ise bir diziye başka bir dizi veya koleksiyonu eklememizi sağlar.
        List<string> list = new List<string> { "elma", "muz" };
        List<string> list2 = new List<string> { "kiraz", "çilek" };
        list.AddRange(list2);

        // Clear methodu ise bir dizi veya koleksiyondaki bütün elemanların silinmesini sağlar.
        List<string> list1 = new List<string> { "elma", "muz" };
        list1.Clear();

        // Contains methodu bir koleksiyonun içinde aranılan şeyin olup olmadığını bulmamızı sağlar.
        ArrayList arrayList1 = new ArrayList();
        bool Varmi = arrayList1.Contains("Muz");
        Console.WriteLine("Var mı: {0}", Varmi);

        // CopyTo fonksiyonu ise bir dizi veya koleksiyonda kullanılır.
        List<string> meyveler = new List<string> { "elma", "muz", "kiraz" };
        string[] dizi = new string[meyveler.Count];
        meyveler.CopyTo(dizi);

        // Count fonksiyonu ise listelerin kaç öğre barındırdığını gösterir.
        List<string> list4 = new List<string> { "elma", "muz", "çilek", "armut", "salatalık", "elma", "kivi" };
        int deger = list4.Count;
        Console.WriteLine("Listedeki meyva sayısı: {0}", deger);

        // GetRange fonksiyonu belli aralıklardaki verileri çeker.
        List<string> meyveler5 = new List<string> { "elma", "muz", "kiraz", "çilek", "portakal" };
        List<string> altMeyveler = meyveler5.GetRange(1, 3);
        Console.WriteLine("Alt Meyveler: " + string.Join(", ", altMeyveler));

        // IndexOf metodu, bir koleksiyonda belirli bir öğenin indeksini bulmak için kullanılır.
        string[] meyveler6 = { "elma", "muz", "kiraz", "çilek" };
        int indeks = Array.IndexOf(meyveler6, "kiraz");
        Console.WriteLine("Kirazın indeksi: " + indeks);

        // Insert methodu ile dizinin istediğimiz bölgesine değeri ekleyebiliriz.
        List<string> deneme = new List<string> { "Kalem", "Silgi", "Uç", "Boya", "Lastik", "Pergel", "Makas", "Bant" };
        deneme.Insert(2, "Kalemtraş");

        // InsertRange metodu, belirli bir indeksin ardından birden fazla öğe eklemek için kullanılır.
        ArrayList yemek = new ArrayList { "elma", "muz", "çilek" };
        ArrayList yeniyemek = new ArrayList { "kiraz", "portakal" };
        yemek.InsertRange(1, yeniyemek);
        Console.WriteLine("Meyveler: " + string.Join(", ", yemek));

        // Remove methodu ile listedeki istediğimiz öğeyi silebiliriz.
        ArrayList silmek = new ArrayList { "Kerem", "Furkan", "Salih", "Kenan", "Müslüm", "Ragıp", "Kadir" };
        silmek.Remove("Furkan");

        // RemoveAt metodu, belirli bir indekste bulunan öğeyi silmek için kullanılır.
        ArrayList silmek1 = new ArrayList { "Kerem", "Furkan", "Salih", "Kenan", "Müslüm", "Ragıp", "Kadir" };
        silmek1.RemoveAt(1);

        // RemoveRange metodu, belirli bir başlangıç indeksinden itibaren birden fazla öğeyi kaldırmak için kullanılır.
        List<string> meyveler7 = new List<string> { "elma", "muz", "kiraz", "çilek", "portakal" };
        meyveler7.RemoveRange(1, 3);
        Console.WriteLine("Meyveler: " + string.Join(", ", meyveler7));

        // Reverse metodu, bir koleksiyondaki öğelerin sırasını tersine çevirir.
        int[] sayilar = { 1, 2, 3, 4, 5 };
        Array.Reverse(sayilar);
        Console.WriteLine("Tersine çevrilmiş dizi: " + string.Join(", ", sayilar));

        // Sort metodu, bir koleksiyondaki öğeleri belirli bir sıralama düzenine göre sıralar.
        List<int> sayi = new List<int> { 1, 2, 15, 18, 19, 4, 5, 163, 13 };
        sayi.Sort();
        Console.WriteLine("Sıralanmış sayılar: " + string.Join(", ", sayi));

        // ToArray metodu, bir koleksiyonu diziye dönüştürmek için kullanılır.
        List<int> sayiar1 = new List<int> { 1, 2, 3, 4, 5 };
        int[] dizimm = sayiar1.ToArray();
        Console.WriteLine("Dizi elemanları: " + string.Join(", ", dizimm));

        // StringCollection sadece string veri tutan ArrayList olarak düşünülebilir.
        StringCollection sc = new StringCollection();
        sc.Add("Yazılım");
        sc.Add("Mühendisliği");
        sc.Add("Furkan Gül");

        // StringDictionary Key ve value ikilisi ile çalışır.
        StringDictionary sd = new StringDictionary();
        sd.Add("isim", "Furkan");
        sd.Add("soyisim", "Gül");
        sd.Add("bölüm", "Yazılım Mühendisliği");

        // ContainsKey metodu, bir sözlükte belirli bir anahtarın var olup olmadığını kontrol eder.
        if (sd.ContainsKey("soyisim"))
        {
            sd.Remove("soyisim");
            Console.WriteLine("soyisim silindi!");
        }
        else
        {
            Console.WriteLine("soyisim isimli anahtar yok!");
        }

        // ContainsValue metodu, bir sözlükte belirli bir değerin var olup olmadığını kontrol eder.
        bool kontrol = sd.ContainsValue("Furkan");
        Console.WriteLine("Var mı: {0}", kontrol);

        // Keys özelliği, bir sözlükte bulunan tüm anahtarları içeren bir koleksiyon döndürür.
        ICollection keyler = sd.Keys;
        foreach (string key in keyler)
        {
            Console.WriteLine(key);
        }

        // Values özelliği, bir sözlükte bulunan tüm değerleri içeren bir koleksiyon döndürür.
        ICollection Valueler = sd.Values;
        foreach (string value in Valueler)
        {
            Console.WriteLine(value);
        }

        // Stack yani yığınlar (son giren ilk çıkar) mantığı ile çalışır.
        Stack denemeStack = new Stack();

        // Push bir yığına öğe eklemek için kullanılır.
        denemeStack.Push("Gül");
        denemeStack.Push("Furkan");

        //Pop Yığından en üstteki öğeyi çıkarır ve döndürür.
        Stack Deneme1 = new Stack();
        Deneme1.Push("Yazılım Mühendisliği");
        Deneme1.Push("Gül");
        Deneme1.Push("Furkan");
        Console.WriteLine(Deneme1.Pop());//Furkan çıkar
        Console.WriteLine(Deneme1.Pop());//Gül çıkar
        Console.WriteLine(Deneme1.Pop());//Yazılım Mühendisliği çıkar


        //Peek methodu ise yığının en üstteki öğesini döndürür, ancak çıkarmadan.
        Stack Deneme2 = new Stack();
        Deneme2.Push("Yazılım Mühendisliği");
        Deneme2.Push("Gül");
        Deneme2.Push("Furkan");
        Console.WriteLine(Deneme2.Peek()); //Furkan çıkar
        Console.WriteLine(Deneme2.Peek()); //Yine Furkan çıkar çünkü yığından çıkarmadı.


        //Queue yani kuyruk koleksiyonları (İlk giren ilk çıkar) mantığı ile çalışır.
        //Stack sınıfından farklı olarak ilk indisinde daima ilk eklenen eleman yer alacaktır.
        //Queue sınıfının tıpkı bir bilet kuyruğuna benzetebiliriz. Daima ilk önce gelen biletini önce alır ve en önce o kuyruktan ayrılır.

        Queue yenideneme = new Queue();

        //Enqueue metodu, kuyruk (queue) veri yapısında yeni bir öğe eklemek için kullanılır.
        yenideneme.Enqueue("Furkan");
        yenideneme.Enqueue(12345);
        yenideneme.Enqueue("Software Engeering");

        Console.WriteLine("Kuyruktaki ögeler: ");
        foreach (var i in yenideneme)
        {
            Console.WriteLine(i);
        }
        //Dequeue metodu, kuyruktaki en eski öğeyi çıkarır ve döndürür. 

        Console.WriteLine(yenideneme.Dequeue()); //Furkan ilk girdiği için çıkar

        //Peek metodu, kuyrukta bulunan en eski öğeyi döndürür, ancak bu öğeyi kuyruktan çıkarmaz.
        Console.WriteLine(yenideneme.Peek()); //Furkan çıktığı için Furkan'dan sonra 123465 ekrana çıakr ama çıkarılmaz.

        //Hashtable StringDictionary sınıfına benzer. Farklı olarak key ve valuedeğerleri object türündedir.

        Hashtable h = new Hashtable();
        h.Add("Furkan", "Gül");
        h.Add(12, 324);
        h.Add(34.36, 67.54);
        h.Add('c', 56);
        h.Add((byte)0, true);

        //SortedList<TKey, TValue>, C#'ta anahtar-değer çiftlerini sıralı bir şekilde depolamak için kullanılan bir koleksiyon türüdür.
        //Hem anahtarlar hem de değerler belirli bir sıraya göre tutulur ve bu koleksiyon, hem indeksli hem de anahtar tabanlı erişim sağlar.

        SortedList<int, string> ogrenciler = new SortedList<int, string>();
        ogrenciler.Add(3, "Ali");
        ogrenciler.Add(1, "Ayşe");
        ogrenciler.Add(2, "Mehmet");

        Console.WriteLine("Sıralı Öğrenci Listesi:");
        foreach (var item in ogrenciler)
        {
            Console.WriteLine($"Numara: {item.Key}, İsim: {item.Value}");
        }

        // 2 numaralı öğrenciyi al
        string ogrenci = ogrenciler[2];
        Console.WriteLine($"\n2 numaralı öğrenci: {ogrenci}");


    }
}
