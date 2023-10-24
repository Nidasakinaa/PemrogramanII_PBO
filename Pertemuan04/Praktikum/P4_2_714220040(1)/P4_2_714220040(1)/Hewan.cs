using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220040_1_
{
    public class Hewan
    {   //Field
        public string namaHewan;
        public string habitat;

        //constr
        public Hewan(string namaHewan, string habitat)
        {
            this.namaHewan = namaHewan;
            this.habitat = habitat;
        }

        //property
        public string NamaHewan
        {
            get { return namaHewan; }
            set { namaHewan = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

    }
}
