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
            int umur = 1;
            int umur2 = 40;
            Console.WriteLine("\nUmur saya kisaran" + umur + " s/d " + umur2);
            const double phi = 3.14;
            Console.WriteLine("\nNilai phi adalah " + phi);
           // phi = 3.14159; // Ini akan menghasilkan error karena phi adalah konstanta
           long myNum= 15000000000L; // Menambahkan 'L' untuk menunjukkan bahwa ini adalah long
                Console.WriteLine("\nNilai myNum adalah " + myNum);
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False
            char myGrade = 'A'; //Tipe data char untuk menyimpan karakter tunggal, diapit oleh tanda kutip tunggal
            Console.WriteLine(myGrade);

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

            //User input
            Console.WriteLine("Masukkan username:");
            string userName = Console.ReadLine();
            Console.WriteLine("usernamenya adalah "+userName);

            Console.WriteLine("Masukkan umur:");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Umurnya adalah "+userAge);

            
        }
    }
}
