using System.Runtime.Intrinsics.X86;

namespace BlackJack;

internal class Program
{
    static void Main(string[] args)
    {
        // Write spade to screen
        //char spade = '\u2660';
        // Console.WriteLine(spade);
        Dealer d1 = new Dealer();
        Player p1 = new Player(d1);

       d1.Shuffle();
        bool hasPassed = false;
        do
        {
            p1.Play();
           p1.ShowCards();
            Console.WriteLine("Volgende kaart? (y/n)");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.N)
            {
                hasPassed = true;
            }
        }
        while (!hasPassed);

    }
}
