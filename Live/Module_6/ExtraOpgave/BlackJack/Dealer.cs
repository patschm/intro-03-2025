namespace BlackJack;

internal class Dealer
{
    private Card[] cards = new Card[52];
    
    private bool AllGone()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] != null) return false;
        }
        return true;
    }
    public Card? GetCard()
    {
        do
        {
            int idx = Random.Shared.Next(0, cards.Length);
            if (cards[idx] != null)
            {
                Card tgt = cards[idx];
                cards[idx] = null;
                return tgt;
            }
        }
        while (!AllGone());
        return null;
    }
    public void Shuffle()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            string stype = "";
            int type = (i+1) / 13;
            switch (type) 
            { 
                case 0:
                    stype = "Hearts";
                    break;
                case 1:
                    stype = "Spades";
                    break;
                case 3:
                    stype = "Diamonds";
                    break;
                case 4:
                    stype = "Clubs";
                    break;                        
            }
            cards[i]= new Card(i+1, stype);
        }
    }
}
