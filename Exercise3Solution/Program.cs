namespace Exercise3Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person(35, "Jonathan", "K", 174, 85);
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