using System.Diagnostics;

int randomNumber = Random.Shared.Next(1, 10000);
Debug.WriteLine(randomNumber);

int numberOfAttempts = 0;
do
{
    numberOfAttempts++;
    Console.WriteLine("Give a number");
    string? userInput = Console.ReadLine();
    if (string.IsNullOrEmpty(userInput)) 
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    int number = int.Parse(userInput);
    if (number == randomNumber)
    {
        Console.WriteLine("You guessed it");
        break;
    }
    if (number > randomNumber)
    {
        Console.WriteLine($"Your guess {number} is greater than the mystery number");
    }
    else
    {
        Console.WriteLine($"Your guess {number} is less than the mystery number");
    }
}
while (true);
Console.WriteLine($"You needed {numberOfAttempts} attempt{(numberOfAttempts > 1 ? "s":"")}.");

