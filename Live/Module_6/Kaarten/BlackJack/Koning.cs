namespace BlackJack;

internal class Koning: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} K]");
    }
    public Koning(char symbol): base(symbol)
    {
        FaceValue = 10;
    }
}
