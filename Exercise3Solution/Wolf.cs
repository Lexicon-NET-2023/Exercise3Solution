using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Wolf : Animal
    {
        public int PackSize { get; set; }
        public Wolf(string name, int age, int packsize) : base(name, age)
        {
            PackSize = packsize;
        }

        public override string DoSound()
        {
            return "*awhooo*";
        }
    }
}
