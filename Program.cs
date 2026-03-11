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

            string removeVeg, searchVeg;
            int removeVegIndex;

            Random generator = new Random();

            List <int> ints = new List <int> (); 


            for (int i = 1; i <= 25; i++)
                {
                    ints.Add(generator.Next(10, 21));
                }


            

            string intChoice = "";
            string stringChoice = "";
            string program = "";

            while (program != "Q")
            {

                Console.Clear();
                Console.WriteLine("What program would you like to use");

                Console.WriteLine("1 - List of Integers");
                Console.WriteLine("2 - List of Strings");
                Console.WriteLine("Q - Quit");

                program = Console.ReadLine().ToUpper().Trim();

                if (program == "1")
                {

                    while (intChoice != "Q")
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
                        Console.WriteLine("Q - Quit");



                        intChoice = Console.ReadLine().ToUpper().Trim();


                        if (intChoice == "1")
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

                        else if (intChoice == "2")
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

                        else if (intChoice == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a number you would like to remove");
                            while (!Int32.TryParse(Console.ReadLine(), out removeValue))
                            {
                                Console.WriteLine("Invalid input! Please enter a valid integer");
                            }

                            if (ints.Contains(removeValue))
                            {

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

                            }

                            else
                            {
                                Console.WriteLine($"The list does not contain the number {removeValue}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        else if (intChoice == "4")
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

                        else if (intChoice == "5")
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

                        else if (intChoice == "6")
                        {
                            Console.Clear();
                            maxValue = ints.Max();

                            Console.WriteLine($"The largest value in the list is {maxValue}");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if (intChoice == "7")
                        {
                            Console.Clear();
                            minValue = ints.Min();

                            Console.WriteLine($"The smallest value in the list is {minValue}");

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }


                        else if (intChoice == "8")
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

                        else if (intChoice == "Q")
                        {
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine();
                        }


                    }
                }


                else if (program == "2")
                {
                    List<string> vegetables = new List<string>() { "CARROT", "BROCCOLI", "CUCUMBER", "PEPPER", "CABBAGE" };


                    Console.Clear();

                    while (stringChoice != "Q")
                    {
                        Console.WriteLine("Vegetables");
                        Console.WriteLine();
                        for (int i = 0; i < vegetables.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + vegetables[i]);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Please select one of the following options:");
                        Console.WriteLine("1 - Remove Vegetable By Index");
                        Console.WriteLine("2 - Remove Vegetable By Value");
                        Console.WriteLine("3 - Search For Vegetable");
                        Console.WriteLine("4 - Add Vegetable");
                        Console.WriteLine("5 - Sort List");
                        Console.WriteLine("6 - Clear List");
                        Console.WriteLine("Q - Quit");
                        Console.WriteLine();

                        stringChoice = Console.ReadLine().ToUpper().Trim();

                        if (stringChoice == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter the index of the vegetable you'd like to remove");

                            while (!Int32.TryParse(Console.ReadLine(), out removeVegIndex) || removeVegIndex > vegetables.Count - 1 || removeVegIndex < 0)                          
                            {
                                Console.WriteLine("Invalid Input. Please ensure you entered an integral number less than the greatest index in the list");
                            }

                            vegetables.Remove(vegetables[removeVegIndex]);

                            Console.WriteLine("Vegetable Removed. Here is the updated list:");

                            for (int i = 0; i < vegetables.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " - " + vegetables[i]);
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        if (stringChoice == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter the name of the vegetable you'd like to remove");

                            removeVeg = Console.ReadLine().ToUpper().Trim();

                            if (vegetables.Contains(removeVeg))
                            {
                                vegetables.Remove(removeVeg);
                            }

                            Console.WriteLine("Vegetable Removed. Here is the updated list:");

                            for (int i = 0; i < vegetables.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " - " + vegetables[i]);
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        if (stringChoice == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter the name of the vegetable you'd like to search for");

                            searchVeg = Console.ReadLine().ToUpper().Trim();

                            if (vegetables.Contains(searchVeg))
                            {
                                Console.WriteLine($"The index of {searchVeg} is {vegetables.IndexOf(searchVeg)}");
                            }

                            else
                            {
                                Console.WriteLine($" '{searchVeg}' does not appear in the list");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();

                        }

                        if (stringChoice == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter the name of the vegetable you'd like to add");

                            vegetables.Add(Console.ReadLine().ToUpper().Trim());


                            Console.WriteLine("Vegetable added. Here is the updated list:");

                            for (int i = 0; i < vegetables.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " - " + vegetables[i]);
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }


                        if (stringChoice == "5")
                        {
                            Console.Clear();

                            vegetables.Sort();

                            Console.WriteLine("List sorted. Here is the updated list:");

                            for (int i = 0; i < vegetables.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " - " + vegetables[i]);
                            }

                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }


                        if (stringChoice == "6")
                        {
                            Console.Clear();

                            vegetables.Clear();

                            Console.WriteLine("List cleared");


                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to return to menu");
                            Console.ReadLine();
                            Console.Clear();
                        }

                    }

                }

                else if (program != "Q")
                {
                    Console.WriteLine("Invalid Input!");
                }


            }
        }
    }
}
