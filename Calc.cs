namespace SwedishInstrumentsTI83
{
    internal class Calc
    {
        public static void Calculations(ref List<string> saves)
        {
            // Declaring the variables needed for the calculations
            var choiceID = 0;
            decimal result = 0.0m;
            decimal input_1 = 0.0m;
            decimal input_2 = 0.0m;
            string operand = " ";
            // Cleaning the console and setting up for another go...
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("ADDITION                          - press 1");
            Console.WriteLine("SUBTRACTION                       - press 2");
            Console.WriteLine("MULTIPLICATION                    - press 3");
            Console.WriteLine("DIVISION                          - press 4");
            Console.WriteLine("");
            Console.WriteLine("RETURN TO MAIN MENU               - press 5");
            Console.WriteLine();



            // KeyPress to decide which calculation we wanna do
            while (true)
            {
                var keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.D1)
                {
                    choiceID = 1;
                    break;

                }
                else if (keypress.Key == ConsoleKey.D2)
                {
                    choiceID = 2;
                    break;

                }
                else if (keypress.Key == ConsoleKey.D3)
                {
                    choiceID = 3;
                    break;

                }
                else if (keypress.Key == ConsoleKey.D4)
                {
                    choiceID = 4;
                    break;

                }
                else if (keypress.Key == ConsoleKey.D5)
                {
                    choiceID = 5;
                    break;

                }
            }
                // Using the ChoiceID to pass arguments into calculations
                switch (choiceID)
                {
                    case 1: // Addition
                        Console.Write("Please provid the first number: ");
                        input_1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Please provid the second number: ");
                        input_2 = decimal.Parse(Console.ReadLine());
                        operand = "+";
                        result = input_1 + input_2;
                        break;

                    case 2: // Subtraction
                        Console.Write("Please provid the first number: ");
                        input_1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Please provid the second number: ");
                        input_2 = decimal.Parse(Console.ReadLine());
                        operand = "-";
                        result = input_1 - input_2;
                        break;

                    case 3: // Multiplication
                        Console.Write("Please provid the first number: ");
                        input_1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Please provid the second number: ");
                        input_2 = decimal.Parse(Console.ReadLine());
                        operand = "*";
                        result = input_1 * input_2;
                        break;

                    case 4: // Division
                        Console.Write("Please provid the first number: ");
                        input_1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Please provid the second number: ");
                        input_2 = decimal.Parse(Console.ReadLine());
                        operand = "/";
                        if (input_2 == 0)
                        {
                            Console.WriteLine("Sorry, we're not equipped to handle 0-Divisions...");
                            Console.WriteLine("Taking you back to main Menu in 2sec.");
                            Thread.Sleep(2000);
                        Menu.MainMenu(ref saves);
                        }
                        else
                        {
                            result = input_1 / input_2;
                            break;
                        }
                        break;


                    case 5: // Go back to Main Menu
                        Menu.MainMenu(ref saves);
                        break;
            }
            // Make sure something has been calculated before saving, if it's 0
            // return to Main Menu without population the save List.
            if (input_1 == 0.0m || result == 0.0m)
            {
                Menu.MainMenu(ref saves);
            }
            else
            {
                // Posting Result and saving it to the list
                string save = "Your Calculation: " + input_1 + " " + operand + " " + input_2 + "=" + result;
                Console.WriteLine(save);
                saves.Add(save);
            }

        }

    }
}

