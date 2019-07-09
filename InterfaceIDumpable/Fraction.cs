using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIDumpable
{
    internal class Fraction : IDumpable
    {
        int z, n;

        public Fraction(int z, int n)
        {
            this.z = z;
            this.n = n;
        }

        public string Name { get; set; }

        public void Dump()
        {
            Console.WriteLine("Fraction : " + z + "/" + n);
        }
    }
}
