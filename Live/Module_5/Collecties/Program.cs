namespace Collecties;

class Program
{
    static void Main(string[] args)
    {
        // Variable of type int array
        // Declaration and intalization of an array
        // Methode 1
        //int[] nummers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        // Method 2
        //int[] nummers = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        // Method 3
        // Must be in the same line
        //int[] nummers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        // Method 4
        // Can be in different lines
        int[] nummers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // nummers[0] = 1;
        // nummers[1] = 2; 
        // nummers[2] = 3;
        // nummers[3] = 4;
        // nummers[4] = 5;
        // nummers[5] = 6;
        // nummers[6] = 7;
        // nummers[7] = 8;
        // nummers[8] = 9;
        // nummers[9] = 10;

        int element = nummers[5];
        Console.WriteLine(element);

        System.Console.WriteLine(nummers.Length);
    


    }
}
