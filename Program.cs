namespace Topic_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int removeValue, addValue, count, countValue, maxValue, minValue, commonValue, commonCount;
            count = 0;
            commonCount = 0;
            commonValue = 0;

            Random generator = new Random();

            List <int> ints = new List <int> (); 


            for (int i = 1; i <= 25; i++)
                {
                    ints.Add(generator.Next(10, 21));
                }


            

            string choice = "";
            string program = "";

            while (program != "Q")
            {
                Console.WriteLine("What program would you like to use");

                Console.WriteLine("1 - List of Integers");
                Console.WriteLine("2 - List of Strings");

                if (program == "1")
                {

                    while (choice != "Q")
                    {
                        Console.WriteLine("Your numbers are: ");

                        foreach (int i in ints)
                        {
                            Console.Write(i + ", ");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Please select one of the following options to do with you list of numbers");
                        Console.WriteLine("1 - Sort List");
                        Console.WriteLine("2 - Create New List");
                        Console.WriteLine("3 - Remove a Value");
                        Console.WriteLine("4 - Add a Value");
                        Console.WriteLine("5 - Count Appearances of Value");
                        Console.WriteLine("6 - Print Largest Value");
                        Console.WriteLine("7 - Print Smallest Value");
                        Console.WriteLine("8 - Print Sum and Average");
                        Console.WriteLine("9 - Print Most Common Value");
                        Console.WriteLine("Q - Quit");



                        choice = Console.ReadLine().ToUpper().Trim();


                        if (choice == "1")
                        {
                            Console.Clear();
                            ints.Sort();
                            Console.WriteLine("Here is the sorted list:");
                            foreach (int i in ints)
                            {
                                Console.Write(i + ", ");
                            }
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();



                        }

                        else if (choice == "2")
                        {
                            Console.Clear();
                            ints.Clear();
                            for (int i = 1; i <= 25; i++)
                            {
                                ints.Add(generator.Next(10, 21));
                            }

                            Console.WriteLine("Your new numbers are: ");

                            foreach (int i in ints)
                            {
                                Console.Write(i + ", ");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if (choice == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a number you would like to remove");
                            while (!Int32.TryParse(Console.ReadLine(), out removeValue) || removeValue > 20 || removeValue < 10)
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer between 10 and 20");
                            }

                            for (int i = 0; i < ints.Count; i++)
                            {
                                if (ints[i] == removeValue)
                                {
                                    ints.RemoveAt(i);
                                    i--;
                                }
                            }

                            Console.WriteLine($"{removeValue} has been removed. Here is your updated list:");

                            foreach (int i in ints)
                            {
                                Console.Write(i + ", ");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        else if (choice == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a number you would like to add");
                            while (!Int32.TryParse(Console.ReadLine(), out addValue))
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer");
                            }

                            ints.Add(addValue);

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        else if (choice == "5")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a number you would like to count");
                            while (!Int32.TryParse(Console.ReadLine(), out countValue))
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer");
                            }

                            for (int i = 0; i < ints.Count; i++)
                            {
                                if (ints[i] == countValue)
                                {
                                    count++;
                                }
                            }

                            Console.WriteLine($"The number {countValue} appears {count} times in the list");
                            count = 0;

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if (choice == "6")
                        {
                            Console.Clear();
                            maxValue = ints.Max();

                            Console.WriteLine($"The largest value in the list is {maxValue}");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if (choice == "7")
                        {
                            Console.Clear();
                            minValue = ints.Min();

                            Console.WriteLine($"The smallest value in the list is {minValue}");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }


                        else if (choice == "8")
                        {
                            Console.Clear();

                            int sum = ints.Sum();
                            double average = ints.Average();

                            Console.WriteLine($"The sum of the numbers is {sum} and the average of the numbers is {average}");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if (choice == "9")
                        {
                            
                            foreach (int i in ints)
                            {
     
                            }

                            Console.WriteLine($"The most is {commonValue} with {commonCount} appearances");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
            }
        }
    }
}
