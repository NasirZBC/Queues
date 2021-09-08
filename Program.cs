using System;

namespace Queues
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("─────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine("        H1 Queue operations");
            Console.WriteLine();
            Console.WriteLine("─────────────────────────────────────");
            Console.WriteLine();

            Console.WriteLine("1. Add items");
            Console.WriteLine("2. Delete items");
            Console.WriteLine("3. Show the number of items");
            Console.WriteLine("4. Show min and max items");
            Console.WriteLine("5. Find an item");
            Console.WriteLine("6. Print all items");
            Console.WriteLine("7. Exit");
            Console.WriteLine();

            bool programWhileBool = true;

            while (programWhileBool)
            {
                Console.WriteLine("Choose from the list");

                Console.WriteLine();
                if (int.TryParse(Console.ReadLine(), out int categoryChoice) && categoryChoice > 0 && categoryChoice < 8)
                {
                    switch (categoryChoice)
                    {
                        case 1:
                            Console.WriteLine("test");
                            break;
                    }
                }
                else
                {
                    continue;
                }
                bool retryBool = true;
                Console.WriteLine("Do you want to try again? Type y for yes and n for no.");
                while (retryBool)
                {
                    string retryChoice = Console.ReadLine();
                    if (retryChoice == "y")
                    {
                        retryBool = false;
                    }
                    else if (retryChoice == "n")
                    {
                        programWhileBool = false;
                        retryBool = false;
                    }
                    else
                    {
                        Console.WriteLine("Please type y or n depending on what you want.");
                        Console.WriteLine();
                        continue;
                    }
                }
            }
        }
    }
}