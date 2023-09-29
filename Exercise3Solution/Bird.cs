using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }

        public Bird(string name, int age, int wingspan) 
            : base(name, age)
        {
            WingSpan = wingspan; 
        }
        public override string DoSound()
        {
            return "*chirp*";
        }

        public override string Stats()
        {
            //return base.Stats();
            return $"{base.Stats()}, Wingspan: {WingSpan}";
        }
    }
}
