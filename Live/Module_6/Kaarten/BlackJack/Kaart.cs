namespace BlackJack;

internal class Kaart
{
    private char _symbol;
    private int _faceValue;

    protected char Symbol
    { 
        get { return _symbol; } 
        set { _symbol = value; }
    }
    public int FaceValue
    {
        get { return _faceValue; }
        protected set { _faceValue = value; }
    }

    public virtual void Toon()
    {

    }
}
