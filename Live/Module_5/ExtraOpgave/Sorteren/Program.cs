namespace Sorteren;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [5, 2, 4, 7, 2, 7, 9, 1, 8, 3, 6, 3, 8];


        //bool isSwapped = false;
        do
        {
            bool isSwapped = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int first = numbers[i];
                int second = numbers[i + 1];
                if (first > second)
                {
                    // swap
                    numbers[i] = second;
                    numbers[i + 1] = first;
                    isSwapped = true;
                }
            }
           if (!isSwapped) break;
        }
        while (true);
        //while (isSwapped);

        foreach (int item in numbers) 
        {
            Console.Write($"{item}, ");
        }   
    }
}
