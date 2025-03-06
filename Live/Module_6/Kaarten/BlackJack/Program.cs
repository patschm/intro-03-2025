using System.Text;

namespace BlackJack;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding(1200);

        Console.WriteLine('\u2665'); // Heart
        Console.WriteLine('\u2666'); // Diamond
        Console.WriteLine('\u2660'); // Spade
        Console.WriteLine('\u2663'); // Club
    }
}
