using System;
namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Saya lagi belajar C#");
            Console.WriteLine("Kayakanya seru juga");
            Console.WriteLine(6+7);
            Console.Write("ini menggunakan Write saja tanpa WriteLine");
            Console.Write("coba ini baris ke dua tanpa WirteLine");
            string nama = "Imam";
            Console.WriteLine("\nNama saya " + nama);
            int umur = 38;
            Console.WriteLine("\nUmur saya " + umur);
            const double phi = 3.14;
            Console.WriteLine("\nNilai phi adalah " + phi);
           // phi = 3.14159; // Ini akan menghasilkan error karena phi adalah konstanta
        }
    }
}
