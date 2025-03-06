

namespace BlackJack;

internal class Bank : Speler
{
    private List<Kaart> _stock = new List<Kaart>();

    public void Shuffle()
    {
        for (int val = 1; val <= 52; val++)
        {
            char symbol = DetermineSymbol(val);
           Kaart kaart = CreateKaart(val);
        }
    }

    private Kaart CreateKaart(int val)
    {
        throw new NotImplementedException();
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
}
