using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nilai N : ");
            int nilai = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ANAK AYAM TURUN " + nilai);
            Console.WriteLine(" ");

            if (nilai <= 0 || nilai > 10)
            {
                Console.WriteLine("Nilai tidak boleh kurang dari 0, dan tidak boleh lebih dari 10");
            }
            else
            {
                for (int a = nilai; a >= 1; a--)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah 1, mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine($"Anak ayam turunlah {a}, mati satu tinggallah {a - 1}");
                    }
                }
            }
        }
    }
}