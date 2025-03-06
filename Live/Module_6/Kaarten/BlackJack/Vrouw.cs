namespace BlackJack;

internal class Vrouw: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} Queen]");
    }
    public Vrouw(char symbol) : base(symbol)
    {
        FaceValue = 10;
    }
}
