using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220040_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hewan Hewan1 = new Kelinci("Happy", "Darat");
            Hewan Hewan2 = new Gajah("Boni", "Darat");
            Console.WriteLine("\n{0} merupakan nama Kelinci, dan {1} merupakan habitatnya", Hewan1.NamaHewan, Hewan1.habitat);
            Console.WriteLine("\n{0} merupakan nama Gajah, dan {1} merupakan habitatnya", Hewan2.NamaHewan, Hewan2.habitat);
        }
    }
}
