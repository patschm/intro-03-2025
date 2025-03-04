namespace GuessAgain;

internal class Program
{
    static void Main(string[] args)
    {
        // ShowWelcomeScreen
        // GenerateNumber
        // AskForInput
        // CompareInput
        // GoodByeScreen

        ShowWelomeScreen();
        bool isGuessed = false;
        int numberToBeGuessed = GenerateNumber();
        do
        {
            int guessedNumber = AskForInput();
            isGuessed = CompareInput(guessedNumber, numberToBeGuessed);
        }
        while (!isGuessed);
        GoodByeScreen();

    }

    static void ShowWelomeScreen()
    {
        Console.WriteLine("Welcome to our high/low game");
    }
    static int GenerateNumber()
    {
        int nr = Random.Shared.Next(1, 10000);
        return nr;
    }
    static int AskForInput()
    {
        do
        {
            Console.WriteLine("Give a number");
            string? userInput = Console.ReadLine();
            if (IsValidInput(userInput))
            {
                int nr = int.Parse(userInput!);
                return nr;
            }
        }
        while (true);
    }

    static bool IsValidInput(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input");
            return false;
        }
        return true;
    }

    static bool CompareInput(int guess, int toBeGuessed)
    {
        if (guess == toBeGuessed)
        {
            Console.WriteLine("Your guess is right");
            return true;
        }
        if (guess > toBeGuessed)
        {
            Console.WriteLine($"Your guess {guess} is greater than the mystery number");
        }
        else
        {
            Console.WriteLine($"Your guess {guess} is less than the mystery number");
        }
        return false;
    }
    static void GoodByeScreen()
    {
        Console.WriteLine("Bye bye!");
    }
}
