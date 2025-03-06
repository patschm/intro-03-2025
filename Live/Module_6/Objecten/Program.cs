namespace Objecten;

class Program
{
    static void Main(string[] args)
    {
        // Tell the factory new that it needs to create an object according to a certain blueprint (Radiator).
        // Radiator is a user-defined data type.
        // obj1 is the object (an instance of the Radiator class).
        // new is the object factory
        Radiator obj1 = new Radiator("Vaillant");
        Radiator obj2 = new Radiator("Nefit");
        //obj1.temperatuur = 20;
        //obj1.hoogte = 100;
        //obj1.breedte = -50;
        obj1.Breedte = -75;
        Console.WriteLine(obj1.Breedte);
        Console.WriteLine(obj1.Oppervlakte);
        //obj1.SetBreedte(-50);
        //System.Console.WriteLine(obj1.GetBreedte());
       // obj1.merknaam = "Radiator";

        obj1.VerhoogTemperatuur();

        //Console.WriteLine(obj1.Temperatuur);
        Console.WriteLine(obj1.Merknaam);

        // Property initializer
        Radiator obj3 = new Radiator{
            Merknaam = "Jaga", 
            Breedte=200, 
            Hoogte=100};

        obj3.VerlaagTemperatuur();
        
        Console.WriteLine(obj3.Merknaam);
        obj3.VerhoogTemperatuur();
        Console.WriteLine(obj3.Oppervlakte);

        // Dit is nu generaliseren.
        Radiator obj4 = new ConvectieRadiator
        {
            Merknaam = "Jaga",
            Breedte = 200,
            Hoogte = 100,
            VentilatorSnelheid = 500
        };

        // Ik verdiep mij in het object
        (obj4 as ConvectieRadiator).VentilatorSnelheid = 800;
        obj4.VerhoogTemperatuur();
    }
}



