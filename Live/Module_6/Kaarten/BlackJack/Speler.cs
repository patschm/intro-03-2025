
namespace BlackJack;

internal class Speler
{
    protected List<Kaart> _hand = new List<Kaart>();
    private Bank? deler;
    public int Value
    {
        get
        {
            int total = 0;
            foreach (Kaart k in _hand)
            {
                total += k.FaceValue;
            }
            return total;
        }
    }
    public bool IsKapot { get; set; } = false;
    public string? Naam { get; set; }
    public int StoptBij { get; set; } = 21;

    public void SetBank(Bank bank)
    {
        deler = bank;
    }

    public void Pas()
    {
        Console.WriteLine($"Speler {Naam} past");
    }
    public void Speel()
    {
        do
        {
            Console.WriteLine("Kaart? (Y/N)");
            ConsoleKey key = Console.ReadKey().Key;
            Console.WriteLine();
            if (key == ConsoleKey.Y)
            {
                Kaart? k = deler?.GeefKaart();
                if (k != null)
                {
                    _hand.Add(k);
                }
                ShowHand();
                IsKapot = EvalueerHand();
                if (IsKapot)
                {
                    Console.WriteLine("Kapot");
                    return;
                }
                if (Value >= StoptBij)
                {
                    Pas();
                    return;
                }
            }
            if (key == ConsoleKey.N)
            {
                Pas();
                return;
            }
            
            
        }
        while (true);
    }

    private bool EvalueerHand()
    {
        // Zijn we kapot?
        while (true)
        {
            // Wellicht zijn er azen die verlaagd kunnen worden?
            bool hasAces = false;
            foreach (Kaart k in _hand)
            {
                Aas? a = k as Aas;
                if (a != null && a.FaceValue == 10)
                {
                    hasAces = true;
                    a.SetMinValue();
                    break;
                }
            }
            if (Value <= 21) return false;
            if (!hasAces) return true;
        }
    }
    private void ShowHand()
    {
        foreach (Kaart k in _hand)
        {
            k.Toon();
        }
        Console.WriteLine($"({Value})");
    }
}
