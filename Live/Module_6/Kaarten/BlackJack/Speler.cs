


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
        if (deler == null) return;
        do
        {
            bool yn = deler.WilJeEenKaart();
            if (yn == false)
            {
                Pas();
                return;
            }
            Kaart newKaart = deler.GeefKaart();
            _hand.Add(newKaart);

            IsKapot = Value > 21;
            if (IsKapot)
                IsKapot = CorrigeerVoorAzen();
            
            ToonHand();
            if (IsKapot)
            {
                Console.WriteLine($"Speler {Naam} is kapot");
                return;
            }
            if (Value >= AutoPassAt)
            {
                Pas();
                return;
            }
        }
        while (true);
    }

    private bool CorrigeerVoorAzen()
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
                    return false;
                }
            }
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
