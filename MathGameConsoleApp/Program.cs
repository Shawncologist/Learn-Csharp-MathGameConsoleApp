namespace MathGameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, please?");
            string name = Console.ReadLine();
            var date = DateTime.UtcNow;

            Menu(name, date);

            void AdditionGame(string message)
            {
                Console.WriteLine(message);
            }
            void SubtractionGame(string message)
            {
                Console.WriteLine(message);
            }
            void MultiplicationGame(string message)
            {
                Console.WriteLine(message);
            }
            void DivisionGame(string message)
            {
                Console.WriteLine(message);
            }

            void Menu(string name, DateTime date)
            {
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

                switch (userChoice.Trim().ToLower())
                {
                    case "a":
                        AdditionGame("You've selected Addition");
                        break;
                    case "s":
                        SubtractionGame("You've selected Subtraction");
                        break;
                    case "m":
                        MultiplicationGame("You've selected Multiplication");
                        break;
                    case "d":
                        DivisionGame("You've selected Division");
                        break;
                    case "q":
                        Console.WriteLine("Thank you for your time, goodbye");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
        }
    }
}