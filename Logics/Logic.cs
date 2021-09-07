using System;

namespace Queues.Logics
{
     class Logic
    {
        public void userInput()
        {
            bool programWhileBool = true;
            bool retryBool = true;
            string guiOutput;


            while (programWhileBool == true)
            {
                Console.WriteLine("Choose from the list");
                string input = Console.ReadLine();

                Console.WriteLine();
                if (int.TryParse(input, out int categoryChoice) && categoryChoice > 0 && categoryChoice < 8)
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
                retryBool = true;
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