namespace Favorite_color_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Favorite Color App");
            string choice;
            do {
                //, here's a flower in your favorite color, I want to have ascii flowers that get printed but not yet
                Console.Write("\n\nWhat is your favorite of the primary subtractive colors? Red, Yellow, or Blue? ");
                String favorite = Console.ReadLine().ToLower();
                switch (favorite)
                {
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow's my favorite too.");
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("The color of the sky? Nice choice.");
                        break;
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The color of fire? Nice choice.");
                        break;
                }
                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
            Console.WriteLine("Goodbye");
        }
    }
}
