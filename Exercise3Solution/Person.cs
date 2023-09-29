using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3Solution
{
    public class Person
    {

        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;
        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;                 
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be more than 0");
                }
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if(!string.IsNullOrEmpty(value) && value.Length > 1 && value.Length < 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First name must have at least two letters and at most ten!");
                }

            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 2 && value.Length < 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Last name must have at least three letters and at most 15!");
                }
            }
        }


        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
