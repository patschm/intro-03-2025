using System.Reflection.Emit;

namespace JumpForward;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        System.Console.WriteLine("Doe Dit");
        System.Console.WriteLine("Doe Dat");
        System.Console.WriteLine("Doe Zus");
        System.Console.WriteLine("Doe Zo");

        // Range checks
        if (a >= 10)
        {
            System.Console.WriteLine("Afwijkend");
        }
        else if(a > 20)
        {
            System.Console.WriteLine("Anders Afwijkend");
        }

        if (a == 10)
        {

        }
        else if (a == 20)
        {

        }
        else if (a == 30)
        {

        }
        else
        {

        }

        // Switch statement for testing concrete values
        switch(a)
        {
            // case int y when y > 100 && y < 200:
            //     System.Console.WriteLine("A is kleiner dan 10");
            //     break;
            case <9:
                System.Console.WriteLine("A is less than 9");
                break;
            case 10:
                System.Console.WriteLine("A is 10");
                break;
            case 20:
                System.Console.WriteLine("A is 20");
                break;
            case 30:
                System.Console.WriteLine("A is 30");
                break;
            default:
                System.Console.WriteLine("A is iets anders");
                break;
        }

        System.Console.WriteLine("En doorrrrrrrrr");
    }
}
