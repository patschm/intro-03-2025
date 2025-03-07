namespace BlackJack;

internal class Aas: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} A]");
    }
    public void SetMinValue()
    {
        FaceValue = 1;
    }
    public Aas(char symbol): base(symbol)
    {
        FaceValue = 11;
    }
}
