using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Dog : Animal
    {
        public bool IsGoodBoy { get; set; }
        public Dog(string name, int age, bool isGoodBoy) : base(name, age)
        {
            IsGoodBoy = isGoodBoy;
        }

        public override string DoSound()
        {
            return "*woff*";
        }
    }
}
