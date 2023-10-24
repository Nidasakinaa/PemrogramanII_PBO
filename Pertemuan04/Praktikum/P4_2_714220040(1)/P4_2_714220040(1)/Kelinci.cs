using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace P4_2_714220040_1_
{
    //Inheritance
    class Kelinci : Hewan
    {

        //construct
        public Kelinci(string namaHewan, string habitat ) : base(namaHewan, habitat)
        {
            this.Habitat = habitat;
        }

        public string Habitat
        {
            get { return this.habitat; }
            set { this.habitat = value; }
        }
    }
}
