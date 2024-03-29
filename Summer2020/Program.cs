using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weight w1 = new Weight();
            Weight w2 = new Weight(3, 125);
            Weight w3 = new Weight(3128);
            Console.WriteLine( w2);
        }
    }
}
