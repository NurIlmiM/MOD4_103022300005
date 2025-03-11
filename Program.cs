using System;
using System.Collections.Generic;

public class KodeProduk
{
    private static Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
    {
        { "Laptop", "E100" },
        { "Smartphone", "E101" },
        { "Tablet", "E102" },
        { "Headset", "E103" },
        { "Keyboard", "E104" },
        { "Mouse", "E105" },
        { "Printer", "E106" },
        { "Monitor", "E107" },
        { "Smartwatch0", "E108" },
        { "Kamera", "E109" }
    };

public static string GetKodeProduk(string elektronik)
{
    if (kodeProdukTable.ContainsKey(elektronik))
    {
        return kodeProdukTable[elektronik];
    }
    else
    {
        return "Kode produk tidak ditemukan";
    }
}
}

public class Program
{
    public static void Main()
    {
        Console.Write("Masukkan nama barang elektronik: ");
        string elektronik = Console.ReadLine();

        string kodeProduk = KodeProduk.GetKodeProduk(elektronik);

        Console.WriteLine($"Kode Produk untuk {elektronik} adalah {kodeProduk}");
    }
}
