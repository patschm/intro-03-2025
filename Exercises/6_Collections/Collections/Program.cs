using Bogus;

namespace Collections;
#pragma warning disable CS0168

// TODO 1a: Can I declare a variable here? (yes/no)
// No

internal class Program
{
    // TODO 1b: Can I declare a variable here? (yes/no)
    // No

    static void Main(string[] args)
    {
        // TODO 1c: Can I declare a variable here? (yes/no)
        // Yes

        {
            // TODO 1d: Can I declare a variable here? (yes/no)
            // Yes
        }

        ExerciseArrays();

        ExerciseLists();

        // TODO 4: What is the size of this array?
        short[] numbers;

        // TODO 5: Show the number of elements in this array
        int[] numbers2 = Enumerable.Range(0, Randomizer.RandomInt()).ToArray();

    }
    static void ExerciseArrays()
    {
        // TODO 2a: Define an array that can store 10 names.
        // Initialize and fill it using the Randomizer.RandomName() function.
        // string name = Randomizer.RandomName();
        // Display all the names in the array
        string[] names = new string[10];
        for(int offset = 0;offset < names.Length; offset++) 
        {
            names[offset] = Randomizer.RandomName();
        }

        foreach(string name in names)
        {
            Console.WriteLine(name);
        }

        // TODO 2b: Define an array that can store 100 numbers.
        // Initialize and fill it using the Randomizer.RandomInt() function.
        // Display the numbers in the array
        int[] numbers = new int[100];
        for(int offset = 0; offset < numbers.Length; offset++)
        {
            numbers[offset] = Randomizer.RandomInt();
        }

        foreach(int nr in numbers)
        {
            //Console.WriteLine(nr);
        }
        // TODO 2c: Define an array that can store 50 decimal numbers.
        // Initialize and fill it using the Randomizer.RandomFloat() function.
        // Display the numbers in the array

        float[] decimals = new float[50];
        for(int offset = 0;offset <decimals.Length;offset++)
        {
            decimals[offset] = Randomizer.RandomFloat();
        }
        for(int idx = 0; idx < decimals.Length;idx++)
        {
            //Console.WriteLine(decimals[idx]);
        }
        // TODO 2d: Define an array that can store 20 datetimes.
        // Initialize and fill it using the Randomizer.RandomDate() function.
        // Display the datetimes in the array
        DateTime[] dates = new DateTime[20];
        for(int offset = 0;offset<dates.Length;offset++)
        {
            dates[offset] = Randomizer.RandomDate();
        }

        for(int idx = 0;idx < dates.Length;idx++)
        {
            Console.WriteLine(dates[idx]);
        }
    }
    static void ExerciseLists()
    {
        // TODO 3a: Define a List that can store 10 names.
        // Initialize and fill it using the Randomizer.RandomName() function.
        // string name = Randomizer.RandomName();
        // Display all the names in the array

        List<string> names = new List<string>();
        for (int offset = 0; offset < 10; offset++)
        {
            names.Add(Randomizer.RandomName());
        }

        foreach(string name in names) 
        {
            Console.WriteLine(name);
        }


        // TODO 3b: Define a List that can store 100 numbers.
        // Initialize and fill it using the Randomizer.RandomInt() function.
        // Display the numbers in the array
        List<int> numbers = new List<int>();
        for (int offset = 0; offset < 100; offset++)
        {
            numbers.Add(Randomizer.RandomInt());
        }
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

        // TODO 3c: Define a List that can store decimal (real) numbers.
        // Initialize and fill it using the Randomizer.RandomFloat() function.
        // Display the numbers in the array
        List<float> floats = new List<float>();
        for (int offset = 0; offset < 100; offset++)
        {
            floats.Add(Randomizer.RandomInt());
        }
        foreach (float item in floats)
        {
            Console.WriteLine(item);
        }

        // TODO 3d: Define a List that can store 20 datetimes.
        // Initialize and fill it using the Randomizer.RandomDate() function.
        // Display the datetimes in the array

        List<DateTime> dates = new List<DateTime>();
        for (int offset = 0; offset < 100; offset++)
        {
            dates.Add(Randomizer.RandomDate());
        }

        foreach(DateTime date in dates)
        {
            Console.WriteLine(date);
        }


    }


    // TODO 1e: Can I declare a variable here? (yes/no)
    // No
}
// TODO 1f: Can I declare a variable here? (yes/no)
// No
