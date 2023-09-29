using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, int age, int nrOfSpikes) : base(name, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override string DoSound()
        {
            return "*pip*";
        }
    }
}
