using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Pelican : Bird
    {
        public int PouchSize { get; set; }

        public Pelican(string name, int age, int wingspan, int pouchsize)
            :base(name, age, wingspan)
        {

        }
    }
}
