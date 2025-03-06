using System.Text;

namespace BlackJack;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.GetEncoding(1200);

        Speler sp1 = new Speler { Naam = "Erik" };
        Speler sp2 = new Speler { Naam = "Marlies" };
        
        Tafel t1 = new Tafel();
        t1.MeldAan(sp1);
        t1.MeldAan(sp2);
        t1.Beurt();

    }
}
