namespace SwedishInstrumentsTI83
{
    internal class Menu
    {
        public static void MainMenu(ref List<string> saves) // Setting up the Main Menu for choosing Calculations, List History or Quit
        {

            // Declarion the Var's needed 
            var choiceID = 0;
            // Clean up the screen before next iteration of menu + calculation
            Console.Clear();
            // Main menu listing
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("SIMPLE CALCULATION                -> press 1");
            Console.WriteLine("ADV. MATHS                        -> press 2");
            Console.WriteLine("HISTORY LIST                      -> press 3\n");
            Console.WriteLine("QUIT                              -> press 4\n\n");
        
            // Capturing keypress to determine menu choice
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
            }
            /*
             * Here I choose to go with a IF Statement instead of a Switch one
             * Because I believe it gave more clarity when writing the code into the blocks.
             */ 


            // For Choice 3, we have a History Listing
            // We use a ForEach loop to cycle through all 
            // Available Items in the list "saves" 

            if (choiceID == 3)
            {
                Console.WriteLine("Your History is: ");
                int i = 1;
                foreach (var item in saves)
                {
                    Console.WriteLine(i + " " + item);
                    i++;
                }
                // Checking for input before taking user back to the Menu
                
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press a key to re-open the Main Menu");
                Console.ReadKey(true);
                Menu.MainMenu(ref saves);
            }
            // Choice 4, Quit the program :(
            else if (choiceID == 4)
            {
                Program.Quit();
            }
            // Choice ID 2, running Adv Maths.
            else if (choiceID == 2)
            {
                Maths.AdvMaths(ref saves);
            }
            // No other choice left but 1, run normal Calculus
            else
            {
                Calc.Calculations(ref saves);
            }


            // End of Function
        }
        // End of Class
    }
}
