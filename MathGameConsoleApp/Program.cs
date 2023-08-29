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



        }
    }
}