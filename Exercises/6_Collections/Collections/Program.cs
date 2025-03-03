using Bogus;

namespace Collections;
#pragma warning disable CS0168

// TODO 1a: Can I declare a variable here? (yes/no)

internal class Program
{
    // TODO 1b: Can I declare a variable here? (yes/no)

    static void Main(string[] args)
    {
        // TODO 1c: Can I declare a variable here? (yes/no)

        {
            // TODO 1d: Can I declare a variable here? (yes/no)
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

        // TODO 2b: Define an array that can store 100 numbers.
        // Initialize and fill it using the Randomizer.RandomInt() function.
        // Display the numbers in the array

        // TODO 2c: Define an array that can store 50 decimal numbers.
        // Initialize and fill it using the Randomizer.RandomFloat() function.
        // Display the numbers in the array

        // TODO 2d: Define an array that can store 20 datetimes.
        // Initialize and fill it using the Randomizer.RandomDate() function.
        // Display the datetimes in the array

    }
    static void ExerciseLists()
    {
        // TODO 3a: Define a List that can store 10 names.
        // Initialize and fill it using the Randomizer.RandomName() function.
        // string name = Randomizer.RandomName();
        // Display all the names in the array

        // TODO 3b: Define a List that can store 100 numbers.
        // Initialize and fill it using the Randomizer.RandomInt() function.
        // Display the numbers in the array

        // TODO 3c: Define a List that can store decimal (real) numbers.
        // Initialize and fill it using the Randomizer.RandomFloat() function.
        // Display the numbers in the array

        // TODO 3d: Define a List that can store 20 datetimes.
        // Initialize and fill it using the Randomizer.RandomDate() function.
        // Display the datetimes in the array

    }


    // TODO 1e: Can I declare a variable here? (yes/no)
}
// TODO 1f: Can I declare a variable here? (yes/no)
