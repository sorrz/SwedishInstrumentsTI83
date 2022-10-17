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
            Console.WriteLine("SIMPLE CALCULATION                - press 1");
            Console.WriteLine("ADV. MATHS                        - press 2");
            Console.WriteLine("HISTORY LIST                      - press 3");
            Console.WriteLine("QUIT                              - press 4");
            Console.WriteLine();
            Console.WriteLine();

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
            // IF / ELSE IF To move from the Menu to the choice

            if (choiceID == 3)
            {
                Console.WriteLine("Your History is: ");
                int i = 1;
                foreach (var item in saves)
                {
                    Console.WriteLine(i + " " + item);
                    i++;
                }
            }
            // Choice 4, Quit the program :(
            else if (choiceID == 4)
            {
                Program.Quit();
            }
            else if (choiceID == 2)
            {
                Math.AdvMaths(ref saves);
            }
            else
            {
                Calc.Calculations(ref saves);
            }


            // End of Function
        }
        // End of Class
    }
}
