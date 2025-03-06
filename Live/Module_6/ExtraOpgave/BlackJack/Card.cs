namespace BlackJack;

internal class Card
{
    private string symbol;
    private int value;
    private bool isAce = false;
    private string type;

    public bool IsAce
    {
        get { return isAce; }
    }
    public int Value
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
        }
    }
    private void Translate(int nr)
    {
        switch (nr)
        {
            case 0:
                symbol = "Ace";
                isAce = true;
                value = 10;
                break;
            case 11:
                symbol = "Boer";
                value = 10;
                break;
            case 12:
                symbol = "Vrouw";
                value = 10;
                break;
            case 13:
                symbol = "King";
                value = 10;
                break;
            default:
                symbol = nr.ToString();
                value = nr;
                break;

        }
    }

    public void Show()
    {
        Console.Write($"{type} {symbol} ");
    }

    public Card(int nr, string type)
    {
        this.type = type;
        Translate(nr % 4);
    }
}
