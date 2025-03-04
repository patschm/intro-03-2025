using System.Collections;

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
    
        for(int idx = 0; idx < nummers.Length; idx++)
        {
            int item = nummers[idx];
            Console.Write($"{item}, ");
        }
        System.Console.WriteLine();

        foreach(int item in nummers)
        {
            Console.Write($"{item}, ");
        }

        // OUWE MEUK. NIET GEBRUIKEN
        ArrayList lijst = new ArrayList();
        lijst.Add(1);
        lijst.Add("twee");
        lijst.Add(3.0);
        lijst.Add(true);

        // foreach(int item in lijst)
        // {
        //     Console.WriteLine(item);
        // }

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //list.Add("4");

        foreach(int item in list)
        {
            Console.WriteLine(item);
        }


        // Dictionary
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("een", 1);
        dict.Add("twee", 2);
        dict.Add("drie", 3);

        Console.WriteLine(dict["twee"]);

        foreach(KeyValuePair<string, int> kvp in dict)
        {
            Console.WriteLine($"{kvp.Key} = {kvp.Value}");
        }
        foreach(int item in dict.Values)
        {
            Console.WriteLine(item);
        }   
        // for(int idx = 0; idx < dict.Count; idx++)
        // {
        //     KeyValuePair<string, int> kvp = dict.ElementAt(idx);
        //     Console.WriteLine($"{kvp.Key} = {kvp.Value}");
        // }
    }
}
