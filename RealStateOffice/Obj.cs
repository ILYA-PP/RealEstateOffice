using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateOffice
{
    public struct Obj
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Obj(int i, string n)
        {
            ID = i;
            Name = n;
        }
    };
}
