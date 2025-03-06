namespace BlackJack;

internal class Speler
{
    protected List<Kaart> _hand = new List<Kaart>();
    private Bank? deler;
    public int Value
    {
        get { return 42; }
    }
    public bool IsKapot { get; set; } = false;

    public void SetBank(Bank bank)
    {
        deler = bank;
    }

    public bool Pas()
    {
        Console.WriteLine("Speler past");
        return true;
    }
   public void Speel()
    {
        Console.WriteLine("Speler is aan de beurt");
    }
}
