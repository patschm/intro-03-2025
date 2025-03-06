namespace BlackJack;

internal class Numeriek : Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} {FaceValue}]");
    }
    public Numeriek(int value)
    {
        FaceValue = value;
    }
}
