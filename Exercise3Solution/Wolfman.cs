using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Wolfman : Wolf, IPerson
    {
        //public int ShoeSize { get; set; }

        public Wolfman(string name, int age, int packsize)
            : base(name, age, packsize)
        {

        }
        public string Talk()
        {
            return "I am not a real wolf!";
        }
    }
}
