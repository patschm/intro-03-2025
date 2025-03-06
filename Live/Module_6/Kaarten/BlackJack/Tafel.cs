namespace BlackJack;

internal class Tafel
{
    private List<Speler> _spelers = new List<Speler>();
    private Bank bank = new Bank();
    private bool isGestart = false;

    public void MeldAan(Speler speler)
    {
        if (isGestart)
        {
            Console.WriteLine("Kan nog niet meedoen");
            return;
        }
        Console.WriteLine($"Speler {speler.Naam} doet nu mee");
        speler.SetBank(bank);
        _spelers.Add(speler);
    }

    public void Beurt()
    {
        if (!isGestart)
        {
            Console.WriteLine("We starten...");
            isGestart=true;
            bank.Shuffle();
        }
        foreach(Speler speler in _spelers)
        {
            Console.WriteLine($"Speler {speler.Naam} is aan de beurt");
            speler.Speel();
        }
        Console.WriteLine("De bank is nu aan de beurt");
        bank.Speel();
        isGestart = false;
    }
}
