namespace BlackJack;

internal class Koning: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} King]");
    }
    public Koning()
    {
        FaceValue = 10;
    }
}
