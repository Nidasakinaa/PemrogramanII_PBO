using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220040
{
    public class DVD_714220040 : Product_714220040
    {
        protected string _duration;

        public DVD_714220040(string title, string duration)
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this._duration = duration;

            Console.WriteLine("DVD constructor called");
        }

        public string Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }
    }
}
