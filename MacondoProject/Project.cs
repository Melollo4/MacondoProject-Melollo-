using System;
using System.ComponentModel.Design.Serialization;
using System.Reflection;

class Program
{
    static void Main()
    {

        // Season / Effect Variables
        string currentSeason = "Summer";
        string specialEffects = "";

        // Status Variables
        int settlers = 2;
        int settlerCap = 15;
        int day = 1;
        int ingredients = 3;

        int greenhouses = 0;
        int kitchens = 0;

        int foodProduction = 0;

        int food = 5;
        int materials = 2;
        int components = 0;

        int moonRock = 0;

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
        int surviveForYearCounter = 0;

        bool wentToMars = false;

        // Start Screen Loop
        while (isOnStart)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("                                                         V2.15");
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
                Console.Beep(500, 100); 
                isOnStart = false;
            }
            else if (input == "2")
            {
                // Rules
                Console.Beep(500, 100);   
                Console.Clear();
                Console.WriteLine("Macondo Settlement is YOUR Settlement.\n\nSettlers need one Available Home to be born\n\nThe Settlers eat one Food each at the end of every Month.\n\nThe amount of Actions your can spend in one Month is determined by the number of Settlers.\n\nNot having enough food for the settlers means the death of one of them.\n\nKill all the Settlers and you loose.\n\nGood Luck :]");
                Console.ReadLine();
                Console.Beep(500, 100); 
            }
            else if (input == "3")
            {
                // Credits
                Console.Beep(500, 100); 
                Console.Clear();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                           A Game by Melvin Piirimets (Melollo)");
                Console.ReadLine();
                Console.Beep(500, 100); 
            }
            else if (input == "4")
            {
                // Exit the Program
                Console.Beep(500, 100); 
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
            Console.WriteLine("Months Survived: " + day);
            Console.WriteLine("");
            Console.WriteLine("Current Goal: " + currentGoal);
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
            Console.WriteLine("");
            Console.WriteLine("World Table:");

            Console.WriteLine("");
            Console.WriteLine("                              Current Settler-Cap = " + settlerCap);
            Console.WriteLine("");

                Console.WriteLine("                                   " + settlers + "               " + actionsLeft + "                " + ingredients + "             " + food + "           " + materials + "                " + availableHouses + "             " + money + "          " + components + "         " + moonRock);
                Console.WriteLine("                              [ Settlers  ] [ Actions Left  ] [ Ingredients  ] [ Food  ] [ Materials  ] [ Available Homes  ] [ $  ] [ Components  ] [ Moon Rock  ]");
                Console.WriteLine("1  - End Month");

            if (currentSeason == "Spring")
            {
                Console.Write("2  - Forage Ingredients                     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]              "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+" + ((greenhouses *2) + 4) + "]                                                                       "); Console.ForegroundColor = ConsoleColor.White; 
            }
            else
            {
                Console.Write("2  - Forage Ingredients                     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]              "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+" + ((greenhouses *2) + 3) + "]                                                                       "); Console.ForegroundColor = ConsoleColor.White; 
            }

                Console.Write("3  - Cook Food                                                "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-2]             "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[" + (kitchens +1) + "]                                                    "); Console.ForegroundColor = ConsoleColor.White; 

            if (currentSeason == "Spring")
            {
                Console.Write("4  - Scavenge Materials                     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                                        "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+3]                                         "); Console.ForegroundColor = ConsoleColor.White; 
            }
            else
            {
                Console.Write("4  - Scavenge Materials                     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                                        "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+2]                                         "); Console.ForegroundColor = ConsoleColor.White;
            }

            if (currentSeason == "Fall")
            {
                Console.Write("5  - Build a Home                           "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                                         "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-6]           "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+1]                         "); Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("5  - Build a Home                           "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                                         "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-5]           "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+1]                         "); Console.ForegroundColor = ConsoleColor.White;
            }

                Console.Write("6  - Reproduce                "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[+1]          "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-1]                                                        [-1]                         "); Console.ForegroundColor = ConsoleColor.White;

            if (currentLevel > 1)
            {
                Console.Write("7  - Sell Material                                                                       "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-" + (currentLevel -1) + "]                                "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+" + ((currentLevel -1) *2) + "]"); Console.ForegroundColor = ConsoleColor.White; 

                Console.Write("8  - Buy a Home                                                                                         "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[+1]                 "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-15]"); Console.ForegroundColor = ConsoleColor.White;
            }
            if (currentLevel > 2)
            {
                Console.Write("9  - Sell Food                                                                 "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-" + currentLevel + "]                                                           "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+" + (currentLevel *4) + "]"); Console.ForegroundColor = ConsoleColor.White; 

                Console.Write("10 - Buy Food                                                                  "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[+1]                                          "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-5]"); Console.ForegroundColor = ConsoleColor.White; 
            }
            if (currentLevel > 3)
            {
                Console.Write("11 - Build a Greenhouse                     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]              "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-10] "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[P+2]                                                    "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-50]"); Console.ForegroundColor = ConsoleColor.White;

                Console.Write("12 - Build a Kitchen                        "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                               "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-5] "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[P+1]                                    "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-50]"); Console.ForegroundColor = ConsoleColor.White;

                Console.Write("13 - Build a City Town        "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[P+1]         "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                                                                             "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-100]"); Console.ForegroundColor = ConsoleColor.White;
            }
            if (currentLevel > 4)
            {
                Console.Write("14 - Assemble Component                     "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                                         "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-5]                                "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-50]   "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+1]"); Console.ForegroundColor = ConsoleColor.White;

                Console.Write("15 - Automate Food Production               "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-1]                               "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[P+1]                                                 "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("[-1]"); Console.ForegroundColor = ConsoleColor.White;
            }
            if (currentLevel > 5)
            {
                Console.Write("16 - Fetch a Moon Rock                      "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-3]                                         "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-20]                                "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-50] "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("[-5]         "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[+1]"); Console.ForegroundColor = ConsoleColor.White;
            }
            if (currentLevel > 6)
            {
                Console.Write("17 - Sell a Moon Rock                                                                                                         "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[+150]              "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[-1]"); Console.ForegroundColor = ConsoleColor.White;
            }
            if (currentLevel > 7)
            {
                Console.Write("18 - Go to Mars                                                                                                                                   "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[-100]"); Console.ForegroundColor = ConsoleColor.White;
            }

            // Read Player Input
            string input = Console.ReadLine();

            // Checking Player Input
            // Ending day
            if (input == "1")
            {
                Console.Beep(500, 100); 
                actionsLeft = -1 - actionsLeft;
            }
            // Foraging Ingredients if Player has at least one Action left
            else if (input == "2" && actionsLeft > 0)
            {
                Console.Beep(500, 100); 
                if (currentSeason == "Spring")
                {
                    ingredients += 4;   
                }
                else
                {
                    ingredients += 3;
                }
                ingredients += greenhouses *2;
                actionsLeft --;
            }
            // Cooking Food if Player has at least 2 Ingredients
            else if (input == "3" && ingredients >= 2)
            {
                Console.Beep(500, 100); 
                ingredients -= 2;
                food ++;
                food += kitchens;
            }
            // Scavenging Materials if players has at least one Action left
            else if (input == "4" && actionsLeft > 0)
            {
                Console.Beep(500, 100); 
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
                Console.Beep(500, 100); 
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
            // Reproduces if Player has at least 2 Settlers and one Action left and one Available House and less Settlers than the current Settler-Cap
            else if (input == "6" && settlers > 1 && actionsLeft > 0 && availableHouses > 0 && settlers < settlerCap)
            {
                Console.Beep(500, 100); 
                availableHouses --;
                actionsLeft --;
                settlers ++;
            }
            // Sells Ingredients if Player is a higher Level than 2 and has enough Food to Sell
            else if (input == "9" && currentLevel > 2 && food >= currentLevel)
            {
                Console.Beep(500, 100); 
                food -= currentLevel;
                money += currentLevel *4;
            }
            // Buys Food if Player is a higher Level than 2 and has at least 2 Money
            else if (input == "10" && currentLevel > 2 && money > 1)
            {
                Console.Beep(500, 100); 
                money -= 5;
                food ++;
            }
            // Sells Materials if player is a higher Level than 1 and has enough Materials to Sell
            else if (input == "7" && currentLevel > 1 && materials >= (currentLevel -1))
            {
                Console.Beep(500, 100); 
                materials -= currentLevel -1;
                money += currentLevel *2;
            }
            // Buys an Available House if Player has a higher Level than 1 and has at least 15 Money
            else if (input == "8" && currentLevel > 1 && money > 14)
            {
                Console.Beep(500, 100); 
                money -= 15;
                availableHouses ++;
            }
            // Builds a Greenhouse if Player has a higher Level than 2 and has at least 10 Ingredients and has at least 50 Money
            else if (input == "11" && currentLevel > 2 && ingredients > 9 && money > 49)
            {
                Console.Beep(500, 100); 
                ingredients -= 10;
                money -= 50;
                greenhouses ++;
            }
            // Builds a Kitchen if Player has a higher Level than 2 and has at least 5 Food and has at least 50 Money
            else if (input == "12" && currentLevel > 2 && food > 4 && money > 49)
            {
                Console.Beep(500, 100); 
                food -= 5;
                money -= 50;
                kitchens ++;
            }
            // Builds a City Town if Player has a higher Level than 2 and has at least least 100 Money
            else if (input == "13" && currentLevel > 2 && money > 99)
            {
                Console.Beep(500, 100); 
                money -= 99;
                settlerCap += 10;
            }
            // Assembles one Component if Player has a higher Level than 4 and has at least one Action left and at least 5 Materials and 50 Money
            else if (input == "14" && currentLevel > 4 && materials > 4 && money > 49)
            {
                Console.Beep(500, 100); 
                actionsLeft --;
                materials -= 5;
                money -= 50;
                components ++;
            }
            // Automates Food Production if Player has a higher Level than 4 and has at least one Action left and at least one Component
            else if (input == "15" && currentLevel > 2 && money > 99)
            {
                Console.Beep(500, 100); 
                components --;
                foodProduction ++;
            }
            // Fetches a Moon Rock if Player has a higher level than 5 and has at least 3 Actions left and at least 20 Materials and at least 5 Components and at least 50 Money
            else if (input == "16" && currentLevel > 5 && actionsLeft > 2 && materials > 19 && money > 49 && components > 4)
            {
                Console.Beep(500, 100);
                actionsLeft -= 3;
                materials -= 20;
                money -= 50;
                components -= 5;
                moonRock ++;
            }
            // Sells a Moon Rock if Player has a higher level than 6 and has at least 1 Moon Rock
            else if (input == "17" && currentLevel > 6 && moonRock > 0)
            {
                Console.Beep(500, 100);
                moonRock --;
                money += 150;
            }
            // In case player did a wrong-type or did something they couldn't do
            else
            {
                // Nothing happens
            }

            // Day Ends
            if (actionsLeft < 0)
            {

                if (wentToMars)
                {
                    isAlive = false;
                }

                if (currentLevel == 0)
                {
                    if (settlers > 4)
                    {
                        currentLevel ++;
                            currentGoal = "Level 2: Have 15 Food";
                     }
                }
                if (currentLevel == 1)
                {
                    if (food > 14)
                    {
                        currentLevel ++;
                        currentGoal = "Level 3: Have $50";
                    }
                }
                if (currentLevel == 2)
                {
                    if (money > 99)
                    {
                        currentLevel ++;
                        currentGoal = "Level 4: Survive for another Season";
                        surviveForYearCounter = 4;
                    }
                }
                if (currentLevel == 3)
                {
                    if (surviveForYearCounter < 1)
                    {
                        currentLevel ++;
                        currentGoal = "Level 5: End a Month with 15 Actions left";
                    }
                }
                if (currentLevel == 4)
                {
                    if (actionsLeft < -15)
                    {
                        currentLevel ++;
                        currentGoal = "Level 6: Automate Food Production to a point where manually cooking food is pointless";
                    }
                }
                if (currentLevel == 5)
                {
                    if (foodProduction == settlers)
                    {
                        currentLevel ++;
                        currentGoal = "Level 7: Bring back a souvenir from Space";
                    }
                }
                if (currentLevel == 6)
                {
                    if (moonRock > 0)
                    {
                        currentLevel++;
                        currentGoal = "Level 8: Sell Moon Rocks to earn 500 $";
                    }
                }
                if (currentLevel == 7)
                {
                    if (money > 499)
                    {
                        currentLevel ++;
                        currentGoal = "Level 9: Have exactly 25 Settlers";
                    }
                }
                if (currentLevel == 8)
                {
                    if (settlers == 25)
                    {
                        currentLevel ++;
                        currentGoal = "Level 10: Reach Mars";
                        surviveForYearCounter = -1;
                    }
                }

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

                    if (currentLevel > 4)
                    {
                        Console.WriteLine("You Produced " + foodProduction + " Food.");
                        food += foodProduction;
                    }

                    Console.WriteLine(food + " Food remain.");
                    Console.WriteLine("");
                    day ++;
                    surviveForYearCounter --;
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

                    if (surviveForYearCounter < -1)
                    {
                        // Start eradication of humanity
                    }
                    if (currentLevel > 7 && surviveForYearCounter < -3)
                    {
                        currentGoal = "SURVIVE";
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
                    Console.Beep(500, 100); 
                }
                else
                {
                    if (wentToMars)
                    {
                        Console.Clear();
                        Console.WriteLine("You're actually insane.");
                        Console.WriteLine("It was never meant for anyone to actually do that, regardless of the way you did it.");
                        Console.WriteLine("But since you're so damn determined, I couldn't just leave you with nothing after all of that wasted time.");
                        Console.WriteLine("I'm genuinly impressed.");
                        Console.WriteLine("That's all. Now go back and play the game for REAL this time!");
                    }
                    else if (surviveForYearCounter < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Humanity had no chance against the wildlife of Space.");
                        Console.WriteLine("Humanity was Eradicated.");
                        Console.ReadLine();
                        Console.Beep(500, 1000); 
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Your Settlement was Eradicated.");
                        Console.WriteLine("You Survived for " + day + " Months.");
                        Console.ReadLine();
                        Console.Beep(500, 100); 
                    }
                }

            }

        }

    }
}