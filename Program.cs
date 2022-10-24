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
            




            // Making a List for the History Function, used by all calculations.
            // We are going to be using a string, since we are gonna be saving the entire calculation.
            List<string> saves = new List<string>();

            // Setting up a welcome Message for the intro
            // Using a fixed window Size and Title, we make it a bit more personal.
            Console.SetWindowSize(51, 30);
            Console.Clear();
            Console.Title = "SwedishInstruments TI83";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("//////////////////////////////////////////////////");
            Console.Write("||               ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Swedish");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                        ||");
            Console.Write("||                   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Instruments ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("               ||");
            Console.Write("||                         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("TI 83");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                ||");
            Console.WriteLine("//////////////////////////////////////////////////");

            // Waiting for input to continue
            Console.WriteLine("Press any key to start");     
            Console.ReadKey(true);

            // Jumping into the Menu upon KeyPress, ref the List into the Menu so we can save stuff.
            Menu.MainMenu(ref saves);


        }
    }
}