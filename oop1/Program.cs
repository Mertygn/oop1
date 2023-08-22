using System;

class Arac // Temel sınıf
{
    public string Marka;
    public string Model;
    public int Yil;
    public string Renk;

    // Constructor
    public Arac(string marka, string model, int yil, string renk)
    {
        Marka = marka;
        Model = model;
        Yil = yil;
        Renk = renk;
    }

    public void Calistir()
    {
        Console.WriteLine("Araç çalıştırıldı.");
    }
}

class Otomobil : Arac
{
    public int Kapilar;

    // Constructor
    public Otomobil(string marka, string model, int yil, string renk, int kapilar)
        : base(marka, model, yil, renk)
    {
        Kapilar = kapilar;
    }

    public void KapiSayisiniGoster()
    {
        Console.WriteLine($"Bu otomobilin {Kapilar} kapısı var.");
    }
}

class Bisiklet : Arac
{
    public int TekerlekSayisi;

    // Constructor
    public Bisiklet(string marka, string model, int yil, string renk, int tekerlekSayisi)
        : base(marka, model, yil, renk)
    {
        TekerlekSayisi = tekerlekSayisi;
    }

    public void TekerlekSayisiniGoster()
    {
        Console.WriteLine($"Bu bisikletin {TekerlekSayisi} tekerleği var.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Otomobil otomobil = new Otomobil("NISSAN", "GTR R34", 2000, "Gri", 2);

        Console.WriteLine("***** Otomobil *****");
        Console.WriteLine($"Marka: {otomobil.Marka}");
        Console.WriteLine($"Model: {otomobil.Model}");
        Console.WriteLine($"Yıl: {otomobil.Yil}");
        Console.WriteLine($"Renk: {otomobil.Renk}");
        Console.WriteLine($"Kapı Sayısı: {otomobil.Kapilar}");

        otomobil.Calistir();
        otomobil.KapiSayisiniGoster();

        Bisiklet bisiklet = new Bisiklet("Giant", "Talon", 2023, "Kırmızı", 2);

        Console.WriteLine("***** Bisiklet *****");
        Console.WriteLine($"Marka: {bisiklet.Marka}");
        Console.WriteLine($"Model: {bisiklet.Model}");
        Console.WriteLine($"Yıl: {bisiklet.Yil}");
        Console.WriteLine($"Renk: {bisiklet.Renk}");
        Console.WriteLine($"Tekerlek Sayısı: {bisiklet.TekerlekSayisi}");

        bisiklet.Calistir();
        bisiklet.TekerlekSayisiniGoster();
    }
}
