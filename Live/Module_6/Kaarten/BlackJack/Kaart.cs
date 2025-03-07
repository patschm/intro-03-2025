namespace BlackJack;

abstract class Kaart
{
    private char _symbol;
    private int _faceValue;

    public Kaart(char symbol)
    {
        Symbol = symbol;
    }

    protected char Symbol
    { 
        get { return _symbol; } 
        private set { _symbol = value; }
    }
    public int FaceValue
    {
        get { return _faceValue; }
        protected set { _faceValue = value; }
    }

    public abstract void Toon();
}
