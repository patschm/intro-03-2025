namespace BlackJack;

internal class Boer:Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} Jack]");
    }
    public Boer(char symbol): base(symbol) 
	{
		FaceValue = 10;
	}
}
