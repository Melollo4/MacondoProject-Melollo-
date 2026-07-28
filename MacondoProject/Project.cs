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
            Console.WriteLine("Welcome to the Macondo Settlement!");
            Console.WriteLine("Please chooce one of the following:");
            Console.WriteLine("");
            Console.WriteLine("1 - Play");
            Console.WriteLine("2 - Exit");
            Console.WriteLine("");
            Console.Write("Input the number representing your choice: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                // Start the Game
                isOnStart = false;
            }
            else if (input == "2")
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
            Console.WriteLine("Current Goal:       " + currentGoal);
            Console.WriteLine("");
            Console.WriteLine("Choices:");
            Console.WriteLine("1 - End day early");
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
                int foodEaten = food - settlers;
                Console.WriteLine("Food needed: " + foodEaten);
                Console.WriteLine("Amount of Settlers: " + settlers);
                food -= settlers;

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
                    actionsLeft = 2;
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