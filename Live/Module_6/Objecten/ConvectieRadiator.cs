namespace Objecten;
// ConvectieRadiator erft van Radiator
// Een afgeleide class zal altijd iets toevoegen aan de base class
// Daarmee krijgt hij alle eigenschappen en gedrag van Radiator
// Je kunt kunt maar van een classe tegelijk erven
// Overerving gebruik je om families van objecten te definieren.
// Overerving is een is-a relatie.
class ConvectieRadiator : Radiator
{
    public int VentilatorSnelheid { get; set; } = 0;

    // Met override ACTIVEER ik polymorfisme.
    public override void VerhoogTemperatuur()
    {
        Temperatuur++;
        Console.WriteLine($"De tempartuur van de convectieradiator (die ventileert met {VentilatorSnelheid} rpm) is nu: {this.Temperatuur}");
    }
    public override void VerlaagTemperatuur()
    {
        Temperatuur--;
        Console.WriteLine($"De tempartuur van de convectieradiator (die ventileert met {VentilatorSnelheid} rpm) is nu: {this.Temperatuur}");
    }
    public ConvectieRadiator(string merknaam) : base(merknaam) 
    {
    }
    public ConvectieRadiator()
    {
    }
}
