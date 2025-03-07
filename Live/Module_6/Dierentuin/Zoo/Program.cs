using Zoo.Dieren;
using Zoo.Verbljven;

namespace Zoo;

internal class Program
{
    static void Main(string[] args)
    {
        Dierentuin zoo = new Dierentuin();
        Kooi kooi = new Kooi();
        kooi.VoegToe(new Leeuw());
        kooi.VoegToe(new Tijger());
        kooi.VoegToe(new Clownsvis()); 
        zoo.Add(kooi);

        Steppe steppe = new Steppe();
        steppe.VoegToe(new Giraffe());
        steppe.VoegToe(new Leeuw());
        steppe.VoegToe(new Gnoe());
        zoo.Add(steppe);

        ApenRots rots = new ApenRots();
        rots.VoegToe(new Gorilla());
        rots.VoegToe(new Mandril());
        zoo.Add(rots);

        Aquarium aquarium = new Aquarium();
        aquarium.VoegToe(new Sidderaal());
        aquarium.VoegToe(new Clownsvis());
        aquarium.VoegToe(new Tijger());
        zoo.Add(aquarium);


        zoo.Open();


    }
}
