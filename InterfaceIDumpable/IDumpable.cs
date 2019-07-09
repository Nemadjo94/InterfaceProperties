using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIDumpable
{
    interface IDumpable
    {
        string Name { get; set; }
        void Dump();
    }
}
