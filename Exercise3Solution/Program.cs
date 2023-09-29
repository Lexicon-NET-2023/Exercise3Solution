namespace Exercise3Solution
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            try
            {
                //Person person = new Person(35, "Jonathan", "K", 174, 85);
                Person person = personHandler.CreatePerson(35, "Jonathan", "Krall", 174, 85);
                Console.WriteLine($"My name is {person.FName} {person.LName}! I am {person.Age} years old!");
                Console.ReadKey();
                personHandler.SetAge(person, 36);
                personHandler.SetLName(person, "Olsson");
                Console.WriteLine($"My name is {person.FName} {person.LName}! I am {person.Age} years old!");
                Console.ReadKey();



            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            //person.Age = 35;
            //person.FName = "Jonathan";
            //person.LName = "K";
            //person.Height = 174;
            //person.Weight = 85; 
        }
    }
}