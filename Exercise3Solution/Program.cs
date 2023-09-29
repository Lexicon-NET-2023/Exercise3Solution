using System.Security.Cryptography.X509Certificates;

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
                List<Animal> animals = new List<Animal>()
                {
                    new Bird("Birdie", 5, 15),
                    new Dog("Doggy", 7, true),
                    new Pelican("Pelle", 10, 20, 5),
                    new Wolfman("Walle", 25, 0),
                    new Wolf("Wille", 12, 5),
                    new Dog("Dave", 9, false)
                };
                //List<Dog> dogs = new List<Dog>();
                

                foreach (Animal animal in animals)
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine(animal.DoSound());
                    Console.WriteLine(animal.Stats());
                    
                    if (animal is IPerson)
                    {
                        var temp = animal as IPerson;
                        Console.WriteLine(temp.Talk());
                                            }

                    if(animal is Dog)
                    {
                        var temp = animal as Dog;
                        Console.WriteLine(temp.DoTrick());
                    }
                }
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