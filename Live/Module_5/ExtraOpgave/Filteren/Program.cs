namespace Filteren;

internal class Program
{
    static void Main(string[] args)
    {
        int[] getallen = Enumerable.Range(1000, 9999).ToArray();
        //ShowGetallen(getallen);

        int[] results = WeirdFilterTwoOrMore5s(getallen);
        ShowGetallen(results);

    }

    static int[] FilterTwoOrMore5s(int[] numbers)
    {
        List<int> list = new List<int>();
        for (int idx = 0; idx < numbers.Length; idx++)
        {
            if (HasTwoOrMore5s(numbers[idx]))
            {
                list.Add(numbers[idx]);
            }
        }

        return list.ToArray();
    }

    // Waarom makkelijk doen als het moeilijk kan?
    static int[] WeirdFilterTwoOrMore5s(int[] numbers)
    {
        int nrOf5s = 0;
        for(int i = 0; i < numbers.Length;i++)
        {
            if (HasTwoOrMore5s(numbers[i]))
            {
                nrOf5s++;
            }
        }
        int[] list = new int[nrOf5s];
        int index = 0;
        for (int idx = 0; idx < numbers.Length; idx++)
        {
            if (HasTwoOrMore5s(numbers[idx]))
            {
                list[index++] = numbers[idx];
            }
        }

        return list;
    }
    static bool HasTwoOrMore5s(int getal)
    {
        string input = getal.ToString();
        //int charCounter = 0;
        //for (int i = 0; i < input.Length; i++)
        //{
        //    if ('5' == input[i])
        //    {
        //        charCounter++;
        //    }
        //}
        //return charCounter >= 2;

        return HasTwoOrMore5s(input); // Reuse!
    }
    static bool HasTwoOrMore5s(string input)
    {
        int charCounter = 0;
        for(int i = 0;i < input.Length;i++)
        {
            if ('5' == input[i])
            {
                charCounter++;
            }
        }
        return charCounter>= 2;
    }

    static void ShowGetallen(int[] nrs)
    {
        foreach (int n in nrs) 
        {
            Console.Write($"{n}, ");
        }
    }
}
