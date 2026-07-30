using System;
using System.Reflection;

class Program
{
    static void Main()
    {

        // Season / Effect Variables
        string currentSeason = "Summer";
        string specialEffects = "";

        // Status Variables
        int day = 1;
        int food = 5;
        int settlers = 2;
        int ingredients = 3;
        int materials = 2;

        // Market Variables
        int money = 0;

        // Structures Variables
        int availableHouses = 1;

        string currentGoal = "LvL 1: Have 5 Settlers";
        int currentLevel = 0;

        int actionsLeft = 2;
        
        // Pure Code-Variables
        bool isOnStart = true;
        bool isAlive = true;
        
        int seasonalCountdown = 4;

        // Start Screen Loop
        while (isOnStart)
        {
            Console.Clear();

            
            Console.WriteLine("                    __   __    ________     ______    ______     ___   __    ______     ______                          ");
            Console.WriteLine("                   |  \\_/  |  |   __   |   /  ____|  /  __  \\   |   \\ |  |  |  __  \\   /  __  \\                         ");
            Console.WriteLine("                   | |\\_/| |  |  |__|  |  |  |____  |  |__|  |  |  |\\\\|  |  | |__|  | |  |__|  |                        ");
            Console.WriteLine("                   |_|   |_|  |__|  |__|   \\______|  \\______/   |__| \\___|  |______/   \\______/                         ");
            Console.WriteLine("");
            Console.WriteLine("      ______     _______    ________    ________    __         _______    __   __    _______    __    __    ________    ");
            Console.WriteLine("     /  ____\\   |  ___ _|  |__    __|  |__    __|  |  |       |  ___ _|  |  \\_/  |  |  ___ _|  |   \\ |  |  |__    __|   ");
            Console.WriteLine("     \\____  \\   |  ___|_      |  |        |  |     |  |____   |  ___|_   | |\\_/| |  |  ___|_   |  |\\\\|  |     |  |      ");
            Console.WriteLine("     \\______/   |_______|     |__|        |__|     |_______|  |_______|  |_|   |_|  |_______|  |__| \\___|     |__|      ");            
            Console.WriteLine("");
            

            Console.WriteLine("                                                         v6");
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
                Console.WriteLine("Macondo Settlement is YOUR Settlement.\n\nSettlers need one Available Home to be born\n\nThe Settlers eat one Food each at the end of every Month.\n\nThe amount of Actions your can spend in one Month is determined by the number of Settlers.\n\nNot having enough food for the settlers means the death of one of them.\n\nKill all the Settlers and you loose.\n\nGood Luck :]");
                Console.ReadLine();
            }
            else if (input == "3")
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
            Console.WriteLine("Status:     Months Survived: " + day + " | Settlers: " + settlers);
            Console.WriteLine("Resources:  Food: " + food + " | Ingredients: " + ingredients + " | Materials: " + materials);
            Console.WriteLine("Structures: Available Homes: " + availableHouses);
            Console.WriteLine("");
            Console.WriteLine("Actions left today: " + actionsLeft);
            Console.WriteLine("");
            Console.WriteLine("Current Goal: " + currentGoal);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Seasonal Effect: " + currentSeason );
            if (currentSeason == "Summer")
            {
                Console.WriteLine(": The weather is perfect. Enjoy the day :]");
            }
            else if (currentSeason == "Fall")
            {
                Console.Write(": It's raining like crazy! Homes need more materials to build.");
            }
            else if (currentSeason == "Winter")
            {
                Console.Write(": It's getting cold. The settlers needs one extra piece of food available.");
            }
            else if (currentSeason == "Spring")
            {
                Console.Write(": The wonderful beginning is here! Forage and Scavange for extra stock!");
            }
            Console.WriteLine("");
            if (currentLevel > 2)
            {
                Console.WriteLine("Special Effect(s): " + specialEffects);   
            }
            Console.WriteLine("");
            Console.WriteLine("World Table:");

            Console.WriteLine(" ");

                Console.WriteLine("3  - Cook Food              [Settlers: " + settlers + "] [Actions Left: " + actionsLeft + "] [Ingredients: " + ingredients + "] [Food: " + food + "] [Materials: " + materials + "] [Available Homes: " + availableHouses + "] [$: " + money + "]");


            if (currentSeason == "Spring")
            {
                Console.WriteLine("2  - Forage Ingredients                    [-1]               [+4]                                                                       ");
            }
            else
            {
                Console.WriteLine("2  - Forage Ingredients                    [-1]               [+3]                                                                       ");
            }

                Console.WriteLine("3  - Cook Food                                                [-2]               [+1]                                                    ");

            if (currentSeason == "Spring")
            {
                Console.WriteLine("4  - Scavenge Materials                    [-1]                                             [+3]                                         ");
            }
            else
            {
                Console.WriteLine("4  - Scavenge Materials                    [-1]                                             [+2]                                         ");
            }

            if (currentSeason == "Fall")
            {
                Console.WriteLine("5  - Build a Home                          [-1]                                             [-6]            [+1]                         ");
            }
            else
            {
                Console.WriteLine("5  - Build a Home                          [-1]                                             [-5]            [+1]                         ");
            }

                Console.WriteLine("6  - Reproduce              [+1]           [-1]                                                             [-1]                         ");

            if (currentLevel > 1)
            {
                Console.WriteLine("7  - Sell Ingredients                                         [-" + currentLevel + "]                                                                   [+" + (currentLevel +1) + "]");
                Console.WriteLine("8  - Buy Food                                                                    [+1]                                            [-6]                                ");
            }
            if (currentLevel > 2)
            {
                Console.WriteLine("9  - Sell Material                                                                          [-" + (currentLevel -1) + "]                                 [+" + ((currentLevel -1) *2) + "]");
                Console.WriteLine("10 - Buy a Home                                                                                             [+1]                 [-15]");
            }

            // Read Player Input
            string input = Console.ReadLine();

            // Checking Player Input
            // Ending day
            if (input == "1")
            {
                actionsLeft = -1;
            }
            // Foraging Ingredients if Player has at least one Action left
            else if (input == "2" && actionsLeft > 0)
            {
                if (currentSeason == "Spring")
                {
                    ingredients += 4;   
                }
                else
                {
                    ingredients += 3;
                }
                actionsLeft --;
            }
            // Cooking Food if Player has at least 2 Ingredients
            else if (input == "3" && ingredients >= 2)
            {
                ingredients -= 2;
                food ++;
            }
            // Scavenging Materials if players has at least one Action left
            else if (input == "4" && actionsLeft > 0)
            {
                actionsLeft --;
                if (currentSeason == "Spring")
                {
                    materials += 3;   
                }
                else
                {
                    materials += 2;
                }
            }
            // Building an Available House if player has at least one Action left and 5 Materials or 6 Materials if Current Season is Fall
            else if (input == "5" && actionsLeft > 0 && materials > 4)
            {
                if (currentSeason == "Fall" && materials > 5)
                {
                    actionsLeft --;
                    materials -= 6;
                    availableHouses ++;   
                }
                else if (currentSeason == "Fall")
                {
                    
                }
                else
                {
                    actionsLeft --;
                    materials -= 5;
                    availableHouses ++;   
                }
            }
            // Reproduces if Player has at least 2 Settlers and one Action left and one Available House
            else if (input == "6" && settlers > 1 && actionsLeft > 0 && availableHouses > 0)
            {
                availableHouses --;
                actionsLeft --;
                settlers ++;
            }
            // Sells Ingredients if Player is a higher Level than 1 and has enough Food to Sell
            else if (input == "7" && currentLevel > 1 && food >= currentLevel)
            {
                food -= currentLevel;
                money += currentLevel +1;
            }
            // Buys Food if Player is a higher Level than 1 and has at least 2 Money
            else if (input == "8" && currentLevel > 1 && money > 1)
            {
                money -= 2;
                food ++;
            }
            // Sells Materials if player is a higher Level than 2 and has enough Materials to Sell
            else if (input == "9" && currentLevel > 2 && materials >= (currentLevel -1))
            {
                materials -= currentLevel -1;
                money += currentLevel *2;
            }
            // Buys an Available House if Player has a higher Level than 1 and has at least 15 Money
            else if (input == "10" && currentLevel > 1 && money > 14)
            {
                money -= 15;
                availableHouses ++;
            }
            // In case player did a wrong-type or did something they couldn't do
            else
            {
                // Nothing happens
            }

            // Day Ends
            if (actionsLeft == -1)
            {

                if (currentLevel == 0)
                {
                    if (settlers > 4)
                    {
                        currentLevel ++;
                            currentGoal = "Level 2: Have 20 Food";
                     }
                }
                if (currentLevel == 1)
                {
                    if (food > 19)
                    {
                        currentLevel ++;
                        currentGoal = "Level 3: Have $100";
                    }
                }
                if (currentLevel == 2)
                {
                    if (money > 99)
                    {
                        currentLevel ++;
                        currentGoal = "Enjoy life :]";
                    }
                }
                // (Survive the next Year)

                if (specialEffects == "Heatwave: You'll loose 2 extra Food at the end of the Month")
                {
                    food -= 2;
                }

                // clear screen, show food eaten and if survived (remove one settler if not enough food, isAlive = false if 0 settlers), set food to 0 if negative, reset actions, increase day by one)
                Console.Clear();
                Console.WriteLine("Food: " + food);
                Console.WriteLine("Current Settlers: " + settlers);
                if (currentSeason == "Winter")
                {
                    food = food - settlers -1;
                }
                else
                {
                    food = food - settlers;
                }

                if (food < 0)
                {
                    // Not enough Food for the Settlers
                    Console.WriteLine("There was not enough Food for all the Settlers...");
                    Console.WriteLine("One Settler died of starvation");
                    settlers --;
                    food = 0;

                    if (settlers <= 0)
                    {
                        isAlive = false;
                    }

                }

                if (isAlive)
                {
                    Console.WriteLine(food + " Food remain.");
                    Console.WriteLine("");
                    day ++;
                    actionsLeft = settlers;
                    seasonalCountdown --;

                    if (seasonalCountdown == 0)
                    {

                        if (currentSeason == "Summer")
                        {
                            currentSeason = "Fall";
                            Console.WriteLine("It is now Fall.");
                            
                        }
                        else if (currentSeason == "Fall")
                        {
                            currentSeason = "Winter";
                            Console.WriteLine("It is now Winter.");
                            
                        }
                        else if (currentSeason == "Winter")
                        {
                            currentSeason = "Spring";
                            Console.WriteLine("It is now Spring.");
                            
                        }
                        else if (currentSeason == "Spring")
                        {
                            currentSeason = "Summer";
                            Console.WriteLine("It is now Summer.");
                            
                        }

                        seasonalCountdown = 4;

                    }

                    if (currentLevel > 2)
                    {
                        Random random = new Random();
                        int rand = random.Next(1, 31);

                        if (rand == 5)
                        {
                            specialEffects = "Heatwave: You'll loose 2 extra Food at the end of the Month";
                            Console.WriteLine("");
                            Console.WriteLine(specialEffects);
                        }
                        else if (rand == 15)
                        {
                            specialEffects = "Perfect Rain: You brought back an extra 5 Ingredients this Month";
                            ingredients += 5;
                            Console.WriteLine("");
                            Console.WriteLine(specialEffects);
                        }
                        else if (rand == 25)
                        {
                            specialEffects = "Encounter: A traveler stumbles upon your settlement and joins.";
                            settlers ++;
                            Console.WriteLine("");
                            Console.WriteLine(specialEffects);
                        }
                        else
                        {
                            specialEffects = "";
                        }
                    }

                    Console.WriteLine("");

                    Console.Write("[Press ENTER to Continue]");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your Settlement was Eradicated.");
                    Console.WriteLine("You Survived for " + day + " days.");
                    Console.WriteLine("Thank you for playing :]");
                    Console.ReadLine();
                }

            }

        }

    }
}