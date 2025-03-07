namespace BlackJack;

internal class Boer:Kaart
{
    public override void Toon()
    {
        Console.Write($"[{Symbol} J]");
    }
    public Boer(char symbol): base(symbol) 
	{
		FaceValue = 10;
	}
}
