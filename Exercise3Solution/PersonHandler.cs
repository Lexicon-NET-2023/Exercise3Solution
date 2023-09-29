using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person; 
        }

        public void SetAge(Person person, int age)
        {
            person.Age = age; 
        }
        public void SetLName(Person person, string lname)
        {
            person.LName = lname;
        }

    }
}
