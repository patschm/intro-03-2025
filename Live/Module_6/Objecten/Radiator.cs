// This is the blueprint of an object.
// It is a class that defines the properties and methods of a Radiator object.
// Radiator is my user-defined data type.
//abstract class Radiator
class Radiator
{
    // Eigenschappen slaan we op in fields.
    // Fields zijn veredeled variabelen.
    // Fields zijn by default private, dus enkel toegankelijk binnen de klasse.
    //private int temperatuur = 15;
    private int hoogte = 75;
    private int breedte = 250;
    //private string? merknaam;// = "Nefit";

    // Dit gecontroleerde toegang to private fields noemen we encapsulation.
    // Encapsulation wordt bereikt mbv Properties


    // Auto-generated properties
    // Ze genereren een private field achter de schermen.
    // Met protected geef ik aan dat alleen afgeleide classes 
    // toegang hebben tot dit property.
    protected int Temperatuur { get; set;} = 15;
    public string? Merknaam { get; set;}
        
    
    public int Oppervlakte
    {
        get
        {
            return this.hoogte * this.breedte;
        }
    }
    public int Hoogte
    {
        get
        {
            return this.hoogte;
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                this.hoogte = value;
            }
            else
            {
                System.Console.WriteLine("Hoogte moet groter zijn dan 0");
            }
        }
    }
    public int Breedte
    {
        get
        {
            return this.breedte;
        }
        set
        {
            if (value > 0 && value < 1000)
            {
                this.breedte = value;
            }
            else
            {
                System.Console.WriteLine("Breedte moet groter zijn dan 0");
            }
        }
    }

    // public int GetBreedte()
    // {
    //     return this.breedte;
    // }
    // public void SetBreedte(int w)
    // {
    //     if (w > 0 && w < 1000)
    //     {
    //         this.breedte = w;
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Breedte moet groter zijn dan 0");
    //     }
    // }

    // Gedrag van een object definieren we op in methods.
    // Methods zijn veredelde functions/procedures.
    // Methods zijn by default private, dus enkel toegankelijk binnen de klasse.
    // Met virtual geef ik aan dat dit GEDRAG!!!! polymorfisch KAN zijn. (Hoeft niet)
    public virtual void VerhoogTemperatuur()
    {
        Temperatuur++;
        Console.WriteLine($"De tempartuur is nu: {this.Temperatuur}");
    }
    // Met abstract geef ik aan dat dit GEDRAG!!!! polymorfisch MOET
    // zijn. (Moet overschreven worden in de afgeleide class)
    // Als je een abstract method hebt, moet de class ook abstract zijn.
    //public abstract void VerlaagTemperatuur();
    public virtual void VerlaagTemperatuur()
    {
        Temperatuur--;
        Console.WriteLine($"De tempartuur is nu: {this.Temperatuur}");
    }
    // Constructors zijn om bedoeld om fields een initiële waarde te geven.
    // Constructors hebben geen return type.
    // Constructors hebben dezelfde naam als de klasse.
    // Constructors worden aangeroepen met het new keyword
    // Er is altijd een default constructor aanwezig die vervalt op het moment 
    // dat je een eigen constructor schrijft.
    public Radiator(string merknaam)
    {
        this.Merknaam = merknaam;
    }
    public Radiator()
    {
    }
}