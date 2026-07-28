using System;
using System.Reflection;

class Program
{
    static void Main()
    {

        int day = 1;
        int food = 5;
        int settlers = 2;
        int ingredients = 3;

        string currentGoal = "Have 5 Settlers";

        int money = 0;

        int actionsLeft = 2;
        
        bool isOnStart = true;
        bool isAlive = true;

        // Start Screen Loop
        while (isOnStart)
        {
            Console.Clear();

            /*
            Console.WriteLine("                    __   __    ________     ______    ______     __    __    ______     ______                          ");
            Console.WriteLine("                   |  \_/  |  |   __   |   /  ____|  /  __  \   |   \ |  |  |  __  \   /  __  \                         ");
            Console.WriteLine("                   | |\_/| |  |  |__|  |  |  |____  |  |__|  |  |  |\\|  |  | |__|  | |  |__|  |                        ");
            Console.WriteLine("                   |_|   |_|  |__|  |__|   \______|  \______/   |__| \___|  |______/   \______/                         ");
            Console.WriteLine("");
            Console.WriteLine("      ______     _______    ________    ________    __         _______    __   __    _______    __    __    ________    ");
            Console.WriteLine("     /  ____\   |  ___ _|  |__    __|  |__    __|  |  |       |  ___ _|  |  \_/  |  |  ___ _|  |   \ |  |  |__    __|   ");
            Console.WriteLine("     \____  \   |  ___|_      |  |        |  |     |  |____   |  ___|_   | |\_/| |  |  ___|_   |  |\\|  |     |  |      ");
            Console.WriteLine("     \______/   |_______|     |__|        |__|     |_______|  |_______|  |_|   |_|  |_______|  |__| \___|     |__|      ");            
            Console.WriteLine("");
            */

            Console.WriteLine("                                 ''Macondo Settlement is YOUR Settlement''");
            Console.WriteLine("");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Rules");
            // Settings
            Console.WriteLine("3 - Credits");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("");
            Console.WriteLine("Input the number representing your choice: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                // Start the Game
                isOnStart = false;
            }
            else if (input == "2")
            {
                // Rules
                Console.Clear();
                Console.WriteLine("Macondo Settlement is YOUR Settlement.\n\nThe Settlers eat one Food each at the end of every day.\n\nThe amount of Actions your can spend in one day is determined by the number of Settlers.\n\nNot having enough food for the settlers means the death of one of them.\n\nKill all the Settlers and you loose.\n\nGood Luck :]");
                Console.ReadLine();
            }
            else if (input == "2")
            {
                // Credits
                Console.Clear();
                Console.WriteLine("Melvin Piirimets (Melollo)");
                Console.ReadLine();
            }
            else if (input == "4")
            {
                // Exit the Program
                Console.Clear();
                Console.Write("Terminating Program...");
                Environment.Exit(1);
            }
            else
            {
                // Restart the While-Loop if none of the above were chosen
            }

        }

        while (isAlive)
        {
            
            // Display and Choices
            Console.Clear();
            Console.WriteLine("Status      Day: " + day + " | Settlers: " + settlers);
            Console.WriteLine("Resources   Food: " + food + " | Ingredients: " + ingredients);
            Console.WriteLine("");
            Console.WriteLine("Actions left today: " + actionsLeft);
            Console.WriteLine("");
            Console.WriteLine("Current Goal: " + currentGoal);
            Console.WriteLine("");
            Console.WriteLine("Choices:");
            Console.WriteLine("1 - End Day");
            Console.WriteLine("2 - Forage Ingredients     [+3 Ingredients] [-1 Action]");
            Console.WriteLine("3 - Cook Food              [-2 Ingredients] [+1 Food]");
            Console.WriteLine("4 - Reproduce              [+1 Settler]     [-1 Action]");

            // Read Player Input
            string input = Console.ReadLine();

            // Checking Player Input
            // Ending day Early
            if (input == "1")
            {
                actionsLeft = -1;
            }
            // Foraging Ingredients if Player has at least one Action left
            else if (input == "2" && actionsLeft > 0)
            {
                ingredients += 3;
                actionsLeft --;
            }
            // Cooking Food if Player has at least 2 Ingredients
            else if (input == "3" && ingredients >= 2)
            {
                ingredients -= 2;
                food ++;
            }
            // Reproduces if Player has at least 2 Settlers and one Action left
            else if (input == "4" && settlers > 1 && actionsLeft > 0)
            {
                settlers ++;
                actionsLeft --;
            }
            // In case player did a wrong-type or did something they couldn't do
            else
            {
                // Nothing happens
            }

            // Day Ends
            if (actionsLeft == -1)
            {
                // clear screen, show food eaten and if survived (remove one settler if not enough food, isAlive = false if 0 settlers), set food to 0 if negative, reset actions, increase day by one)
                Console.Clear();
                Console.WriteLine("Food: " + food);
                Console.WriteLine("Current Settlers: " + settlers);
                food = food - settlers;

                if (food < 0)
                {
                    // Not enough Food for the Settlers
                    Console.WriteLine("There was not enough Food for all the Settlers...");
                    Console.WriteLine("One Settler died of starvation");

                    if (settlers <= 0)
                    {
                        isAlive = false;
                    }
                    else
                    {
                        Console.WriteLine(settlers + " Settlers remain.");
                    }
                }
                else
                {
                    Console.WriteLine(food + " Food remains.");
                    day ++;
                    actionsLeft = settlers;
                    Console.Write("[Press ENTER to Continue]");
                    Console.ReadLine();
                }

            }

        }

        Console.WriteLine("Your Settlement was Eradicated.");
        Console.WriteLine("You Survived for " + day + " days.");
        Console.WriteLine("Thank you for playing :]");

    }
}