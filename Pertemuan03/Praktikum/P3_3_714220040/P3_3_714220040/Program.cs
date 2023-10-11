using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_3_714220040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENU HITUNG PERSEGI PANJANG\n---------------------");
                Console.WriteLine("\n1. Menghitung Luas");
                Console.WriteLine("2. Menghitung Keliling");

                Console.WriteLine("Menu Pilihan : ");


                int pilihan = int.Parse(Console.ReadLine());

                double Panjang, Lebar;

                if (pilihan == 1)
                {
                    Console.WriteLine("Masukan panjang");
                    int Angka1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Masukan Lebar");
                    int Angka2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("");

                    int Luas = Angka1 * Angka2;
                    Console.WriteLine("Luas persegi panjang = {2}", Angka1, Angka2, Luas);
                }



                else if (pilihan == 2)
                {
                    Console.WriteLine("Masukan panjang");
                    int Angka1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Masukan Lebar");
                    int Angka2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("");

                    int Keliling = 2 * (Angka1 + Angka2);
                    Console.WriteLine("Keliling persegi panjang = {3}", 2, Angka1, Angka2, Keliling);

                }
                Console.Write("\nIngin mengulang kembali (Ya/Tidak)? ");

            }

            while (Console.ReadLine() == "Ya");
        }
    }
}
