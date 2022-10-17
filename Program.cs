using System.Security.Cryptography.X509Certificates;

namespace SwedishInstrumentsTI83
{
    public class Program
    {
       public static void Quit()
        {
            Environment.Exit(200);
        }
        static void Main(string[] args)
        {
            




            // Making a List for the History Function, used by all calculations. We're saving a string of output.
            List<string> saves = new List<string>();

            // Setting up a welcome Message for the intro
            Console.SetWindowSize(51, 30);
            Console.Clear();
            Console.Title = "Calculator of Doom 3000";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||++++++++++++++++++++++++++++++++++++++++++++++||");
            Console.Write("||-------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("THE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------||");
            Console.Write("||********************** ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Calculator of");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" *********||");
            Console.Write("||-------------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("DOOM 3000");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ---------------||");
            Console.WriteLine("||==============================================||");

            // Waiting for input to continue
            Console.WriteLine("Press any key to start");     
            Console.ReadKey(true);

            
            Menu.MainMenu(ref saves);





            // Keep this here for unwanted exits
            Console.ReadLine();
        }
    }
}