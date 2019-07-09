using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIDumpable
{
    internal class Person : IDumpable
    {
        private string lastName;
        private string address;
        private int phone;

        public Person(string name, string lastName, string address, int phone)
        {
            this.Name = name;
            this.lastName = lastName;
            this.address = address;
            this.phone = phone;
        }

        public string Name { get; set; }

        public void Dump()
        {
            Console.WriteLine($"Person Details : Name: {Name}, Last Name: {lastName}, Address: {address}, Phone: {phone}");
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
