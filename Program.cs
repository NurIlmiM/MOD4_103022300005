//using System;
//using System.Collections.Generic;

//public class KodeProduk
//{
//    private static Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
//    {
//        { "Laptop", "E100" },
//        { "Smartphone", "E101" },
//        { "Tablet", "E102" },
//        { "Headset", "E103" },
//        { "Keyboard", "E104" },
//        { "Mouse", "E105" },
//        { "Printer", "E106" },
//        { "Monitor", "E107" },
//        { "Smartwatch0", "E108" },
//        { "Kamera", "E109" }
//    };

//    public static string GetKodeProduk(string elektronik)
//    {
//        if (kodeProdukTable.ContainsKey(elektronik))
//        {
//            return kodeProdukTable[elektronik];
//        }
//        else
//        {
//            return "Kode produk tidak ditemukan";
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Console.Write("Masukkan nama barang elektronik: ");
//        string elektronik = Console.ReadLine();

//        string kodeProduk = KodeProduk.GetKodeProduk(elektronik);

//        Console.WriteLine($"Kode Produk untuk {elektronik} adalah {kodeProduk}");
//    }
//}


using System;

public class FanLaptop
{
    public enum State { Turbo, Balanced }

    private State currentState;

    public FanLaptop()
    {
        currentState = State.Turbo;
        Console.WriteLine("Fan Quiet berubah menjadi Turbo");
    }

    public void HandleCommand(string command)
    {
        switch (currentState)
        {
            case State.Turbo:
                if (command == "Turbo")
                {
                    currentState = State.Balanced;
                    Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                }
                break;

            case State.Balanced:
                if (command == "Balanced")
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                }
                break;
        }
    }
}

public class Program
{
    public static void Main()
    {
        FanLaptop laptop = new FanLaptop();

        while (true)
        {
            Console.Write("Enter Command: ");
            string command = Console.ReadLine();

            if (command == "QUIT") break;

            laptop.HandleCommand(command);
        }
        Console.WriteLine("Program selesai. ");
    }
}