

namespace SwedishInstrumentsTI83
{
    internal class Maths
    {
        public static void AdvMaths(ref List<string> saves)
        {
            
            // Declaring the variables needed for the calculations
            // I have opted to go for doubles here as the calculations are a bit odd to work with Decimal.

            // I have re-used the same names again, so I could re-use much of the code in a easy way - and keep the readability
            var choiceID = 0;
            double result = 0.0;
            double input_1 = 0.0;
            double input_2 = 0.0;
            string operand = " ";

            // Cleaning the console and setting up for another go...
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("SQRT                              -> press 1");
            Console.WriteLine("CIRCLE CIRCUMFERENCE              -> press 2");
            Console.WriteLine("TRIANGLE AREA (base+height)       -> press 3\n\n");
            Console.WriteLine("RETURN TO MAIN MENU               -> press 5\n");


            // KeyPress to decide which calculation we wanna do
            // We Check the Key to determine the Choice Made, and then lead that into the Switch Using a Choice Variable
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
                // Saving an Operand, the Inputs and the result
                switch (choiceID)
                {
                    case 1: // Addition
                        Console.Write("Please provid the first number: ");
                        input_1 = double.Parse(Console.ReadLine());

                        operand = "Sqrt";
                        result = Math.Sqrt(input_1);
                        break;

                    case 2: 
                            //Do 2nd function
                            //O = (2 * R) * PI
                        Console.Write("What is the Radius of the Circle: ");
                        input_1 = double.Parse(Console.ReadLine());
                        operand = " (r*2)*Pi ";
                        result = (input_1 * 2) * Math.PI;

                       
                        break;

                    case 3: 
                            //Do 3rd function
                            // A = 1/2 (base × height)
                        Console.Write("What is the Base of the Triangle: ");
                        input_1 = double.Parse(Console.ReadLine());
                        Console.Write("What is the Height of the Triangle: ");
                        input_2 = double.Parse(Console.ReadLine());
                        operand = " (x*y)*0,5 ";
                        result = 0.5 * (input_1 * input_2);
                    
                        break;



                    case 5: // Go back to Main Menu
                        Menu.MainMenu(ref saves);
                        break;
                }
            }
            //Catching bad input, moving the user back to the Top-Menu!
            // This is the easiest way I've found to catch bad input, and an easy way to handle it.
            // Take them back to the top to redo or opt to do something else.
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fel vid inmatning, tar dig tillbaka till menyn.");
                Thread.Sleep(2000);
                AdvMaths(ref saves);


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
                AdvMaths(ref saves);
            }
            else
            {
                Menu.MainMenu(ref saves);

            }


        }
    }
}
