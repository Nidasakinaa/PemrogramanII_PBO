using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220040
{
     class ProductTest_714220040
    {
        static void Main(string[] args)
        {
            Book_714220040 product1 = new Book_714220040("Book", "C# Object Oriented Solution", "300");
            DVD_714220040 product2 = new DVD_714220040("Ethernal sunshine of The Spotless Mind", "145");

            Console.WriteLine("product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("product 2 is a {0} called \"{1}\" and has {2} pages", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
