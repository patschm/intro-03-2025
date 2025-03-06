
namespace BlackJack;

internal class Player
{
    private List<Card> _cards = new List<Card>();
    private Dealer _dealer;

    public Player(Dealer dealer)
    {
        _dealer = dealer;
    }

    public void ShowCards()
    {

        foreach (Card card in _cards)
        {
            card.Show();
        }
        Console.WriteLine();
    }
    public void Play()
    {
        Card? c = _dealer.GetCard();
        if (c != null)
        {
            _cards.Add(c);
        }
    }
    public int Value
    {
        get
        {
            int total = 0;
            foreach (var card in _cards)
            {
                total += card.Value;
            }
            total = CorrectForAces(total);
            
            return total;
        }
    }

    private int CorrectForAces(int total)
    {
        if (total > 21)
        {
            foreach (var card in _cards)
            {
                if (card.IsAce)
                {
                    card.Value = 1;
                    total -= 9;
                }
            }
        }
        return total;
    }
}
