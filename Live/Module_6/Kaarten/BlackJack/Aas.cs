namespace BlackJack;

internal class Aas: Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} Ace]");
    }
    public Aas()
    {
        FaceValue = 10;
    }
}
