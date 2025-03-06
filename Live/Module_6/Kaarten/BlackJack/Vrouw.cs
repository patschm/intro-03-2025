namespace BlackJack;

internal class Vrouw: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} Queen]");
    }
    public Vrouw()
    {
        FaceValue = 10;
    }
}
