

namespace BlackJack;

internal class Bank : Speler
{
    private Random _random = new Random();
    private List<Kaart> _stock = new List<Kaart>();

    public Bank()
    {
        AutoPassAt = 17;
        Naam = "Bank";
        SetBank(this);
    }
    public void Shuffle()
    {
        for (int val = 0; val < 56; val++)
        {
            char symbol = DetermineSymbol(val);
            Kaart kaart = CreateKaart(val, symbol);
            if (kaart != null)  _stock.Add(kaart);
        }
    }
    public Kaart GeefKaart()
    {
        if (_stock.Count == 0)
        {
            Console.WriteLine("Kaarten zijn op");
            Shuffle();
        }
        int idx = _random.Next(0, _stock.Count);
        Kaart card = _stock[idx];
        _stock.Remove(card);
        return card;
    }
    private Kaart? CreateKaart(int val, char symbol)
    {
        int card = val % 14;
        switch (card)
        {
            case 0: return null;
            case 1: return new Aas(symbol);
            case 11: return new Boer(symbol);
            case 12: return new Vrouw(symbol);
            case 13: return new Koning(symbol);
            default: return new Numeriek(card, symbol);
        }
    }
    private char DetermineSymbol(int val)
    {
        int isym = val / 14;
        switch (isym)
        {
            case 0:
                return '\u2665'; // Heart
            case 1:
                return '\u2666'; // Diamond
            case 2:
                return '\u2660'; // Spade
            case 3:
                return '\u2663'; // Club
            default:
                return 'x';
        }
    }
    public bool WilJeEenKaart()
    {
        Console.WriteLine("Kaart? (Y/N)");
        ConsoleKey key = Console.ReadKey(true).Key;
        return key == ConsoleKey.Y;
    }
}
