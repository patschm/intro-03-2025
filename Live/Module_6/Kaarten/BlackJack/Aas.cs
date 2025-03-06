namespace BlackJack;

internal class Aas: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} Ace]");
    }
    public void SetMinValue()
    {
        FaceValue = 1;
    }
    public Aas(char symbol): base(symbol)
    {
        FaceValue = 10;
    }
}
