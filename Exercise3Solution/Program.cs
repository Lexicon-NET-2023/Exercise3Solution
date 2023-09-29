namespace Exercise3Solution
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //PersonHandler personHandler = new PersonHandler();
            try
            {
                //Person person = new Person(35, "Jonathan", "K", 174, 85);
                //Person person = personHandler.CreatePerson(35, "Jonathan", "Krall", 174, 85);
                //Console.WriteLine($"My name is {person.FName} {person.LName}! I am {person.Age} years old!");
                //Console.ReadKey();
                //personHandler.SetAge(person, 36);
                //personHandler.SetLName(person, "Olsson");
                //Console.WriteLine($"My name is {person.FName} {person.LName}! I am {person.Age} years old!");
                //Console.ReadKey();

                //List<UserError> errors = new List<UserError>
                //{
                //    new NumericInputError(),
                //    new TextInputError(),
                //    new NumericInputError(),
                //    new TextInputError()
                //};

                //foreach (UserError error in errors)
                //{
                //    Console.WriteLine(error.UEMessage());
                //}
                //Console.ReadKey(); 

                Bird bird = new Bird("Bill", 5, 15);
                Dog dog = new Dog("Dave", 7, true);
                Pelican pelican = new Pelican("Pelle", 3, 20, 5);
                Wolfman wolfman = new Wolfman("Walle", 25, 0);

                Console.WriteLine(bird.DoSound());
                Console.WriteLine(dog.DoSound());
                Console.WriteLine(pelican.DoSound());
                Console.WriteLine(wolfman.DoSound());
                Console.WriteLine(wolfman.Talk());

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