using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--MASUKAN ANGKA---");
            Console.Write("Silakan Masukan Angka Pertama : ");
            double angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angka Pertama, " + angka1);

            Console.WriteLine("--MASUKAN ANGKA---");
            Console.Write("Silakan Masukan Angka Kedua : ");
            double angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angka Kedua, " + angka2);

            double penjumlahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);

            double pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, pengurangan);

            double perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);

            double pembagian = angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);
        }
    }
}
