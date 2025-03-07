


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
    public int AutoPassAt { get; set; } = 21;

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
            ConsoleKey key = Console.ReadKey(true).Key;
            Console.WriteLine();
            if (key == ConsoleKey.Y)
            {
                SpeelKaart();
                bool kanDoor = CanContinue();
                ToonHand();
                if (!kanDoor)
                {
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
      
    private bool CanContinue()
    {
        // TODO. Her gaat iets mis
        if (Value == 21)
        {
            Pas();
            return false;
        }
        if (Value < 21) return true;
        IsKapot = HeeftAzen();
        if (IsKapot)
        {
            Console.WriteLine("Kapot");
            return false;
        }
        if (Value >= AutoPassAt)
        {
            Pas();
            return false;
        }
        return true;
    }
    private void SpeelKaart()
    {
        Kaart? k = deler?.GeefKaart();
        if (k != null)
        {
            _hand.Add(k);
        }
       
    }
    private bool HeeftAzen()
    {
        // Zijn we kapot?
        while (true)
        {
            // Wellicht zijn er azen die verlaagd kunnen worden?
            bool hasAces = false;
            foreach (Kaart k in _hand)
            {
                Aas? a = k as Aas;
                if (a != null && a.FaceValue == 11)
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
    public void ToonHand()
    {
        foreach (Kaart k in _hand)
        {
            k.Toon();
        }
        Console.WriteLine($"({Value})");
    }
}
