using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIDumpable
{
    class Program
    {
        static void Main(string[] args)
        {
            IDumpable[] a =
            {
                new Fraction(10,3),
                new Fraction(9,4),
                new Person("Nemanja", "Djordjevic","Vojvodina", 1234567),
                new Person("Mihajlo", "Djordjevic", "Vojvodina", 678910)
            };

            a[0].Name = "f1";
            a[1].Name = "f2";
            

            foreach(IDumpable obj in a)
            {
                Console.Write(obj.Name + ": ");
                obj.Dump();
            }
        }
    }
}
