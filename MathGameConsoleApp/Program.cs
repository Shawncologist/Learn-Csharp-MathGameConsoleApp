namespace MathGameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, please?");
            string name = Console.ReadLine();
            var date = DateTime.UtcNow;

            Console.WriteLine("\n - + - + - + - + - + - + - ");
            Console.WriteLine($"Hello {name}, happy {date.DayOfWeek}! Would you like to do some inconvenient console math?\n");
            Console.WriteLine(@$"Please choose your calculation type below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit this program");
            Console.WriteLine(" - + - + - + - + - + - + - ");

            var userChoice = Console.ReadLine();

            if (userChoice.Trim().ToLower() == "a")
            {
                Console.WriteLine("You've selected Addition.");
            }
            else if (userChoice.Trim().ToLower() == "s")
            {
                Console.WriteLine("You've selected Subtraction.");
            }
            else if (userChoice.Trim().ToLower() == "m") 
            {
                Console.WriteLine("You've selected Multiplication.");
            }
            else if (userChoice.Trim().ToLower() == "d")
            {
                Console.WriteLine("You've selected Division.");
            }
            else if (userChoice.Trim().ToLower() == "q")
            {
                Console.WriteLine("Thank you for your time, goodbye.");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
    }
}