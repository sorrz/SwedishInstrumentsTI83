namespace SwedishInstrumentsTI83
{
    internal class Calc
    {
        public static void Calculations(ref List<string> saves)
        {
            // Declaring the variables needed for the calculations
            // I decided to go for Decimal here to ensure we get specific calculations
            // if the user wanted to do small calulations that needs to be exact.
            var choiceID = 0;
            decimal result = 0.0m;
            decimal input_1 = 0.0m;
            decimal input_2 = 0.0m;
            string operand = " ";

            // Cleaning the console and setting up for another go...
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("ADDITION                          -> press 1");
            Console.WriteLine("SUBTRACTION                       -> press 2");
            Console.WriteLine("MULTIPLICATION                    -> press 3");
            Console.WriteLine("DIVISION                          -> press 4\n\n");
            Console.WriteLine("RETURN TO MAIN MENU               -> press 5\n");


            // KeyPress to decide which calculation we wanna do
            // Passing it into the Switch statement, to do different Calculations.
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
            try
            {
                // Using the ChoiceID to pass arguments into calculations
                // Do the Calculation you have choosen from the Menu. 
                // Saving an Operand, the Inputs and the resulthe ChoiceID to pass arguments into calculations
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
            }
            // Catching FormatExceptions, letting the user know they entered a non-number char.
            // Moving User back to the Calculation meny with the ref to the list.
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel vid inmatning, tar dig tillbaka till menyn.");
                Thread.Sleep(2000);
                Calculations(ref saves);


            }


            // Here we create a string some presentation text, the values, operands and result passed from
            // the Switch statement. 
            // Writing it out for the user and saving it into the List we passed a reference to, stemming from the Main() Function.
            string save = "Your Calculation: " + input_1 + " " + operand + " " + input_2 + "=" + result;
            Console.WriteLine(save);
            saves.Add(save);
            // Asking for continued or go back to main menu?
            // Using a "jump" to the Method of user choice, reffing the List there.
            Console.Write("Wanna do another? (Y/N) ");
            var goagain = Console.ReadKey(true);
            if (goagain.Key == ConsoleKey.Y)
            {
                Calculations(ref saves);
            }
            else
            {
                Menu.MainMenu(ref saves);

            }



        }

    }
}

