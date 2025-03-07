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

    public void StartRonde()
    {
        if (!isGestart)
        {
            Console.WriteLine("We starten...");
            isGestart=true;
            bank.Shuffle();
        }
        foreach(Speler speler in _spelers)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine($"Speler {speler.Naam} is aan de beurt");
            speler.Speel();
        }
        Console.WriteLine("De bank is nu aan de beurt");
        bank.Speel();
        EindEvalutie();
        isGestart = false;
    }

    private void EindEvalutie()
    {
        if (bank.IsKapot)
        {
            SpelerVerliest(bank);
            foreach(Speler speler in _spelers)
            {
                if (!speler.IsKapot)
                {
                    SpelerWint(speler);
                }
                else
                {
                    SpelerVerliest(speler);
                }
            }
        }
        else
        {
            SpelerWint(bank);
            foreach (Speler speler in _spelers)
            {
                if (!speler.IsKapot && speler.Value > bank.Value)
                {
                    SpelerWint(speler);
                }
                else
                {
                    SpelerVerliest(speler);
                }
            }
        }
    }
    private void SpelerWint(Speler speler)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{speler.Naam} wint: ");
        speler.ToonHand();
        Console.ResetColor();
    }
    private void SpelerVerliest(Speler speler)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{speler.Naam} verliest: ");
        speler.ToonHand();
        Console.ResetColor();
    }
}
