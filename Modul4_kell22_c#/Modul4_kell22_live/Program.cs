using System;

namespace Modul4_kell22_live
{
    class Program
    {
        static void non_return(String a, String b, String c)
        {
            Console.WriteLine("Selamat Datang di Praktikum DKP 2020 {0} dan {1} dari {2}", a, b, c);
        }
        static int return_func(int a)
        {
            if (a > 0 && a < 3)
            {
                return a * 3;
            }
            else
            { 
                return a * 0;
            }
        }
        static void Main(string[] args)
        {
            non_return("Andika", "Reehan", "Kell22");
            Console.WriteLine("Ini adalah praktikum shift {0}", return_func(6));
            PERCOBAAN1_KELL22 objek = new PERCOBAAN1_KELL22();
            objek.pembagian(39, 13);
            Console.WriteLine("Hasil pengurangan {0} dengan {1} adalah {2}", 39, 13, objek.pengurangan(39, 13));
            Console.ReadKey();
        }
    }
}
