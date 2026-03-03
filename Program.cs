namespace Topic_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random generator = new Random();

        List <int> ints = new List <int> (); 

        for (int i = 1; i >= 25; i++)
            {
                ints.Add(generator.Next(10, 21));
            }

            Console.WriteLine(ints[7]);


        }
    }
}
