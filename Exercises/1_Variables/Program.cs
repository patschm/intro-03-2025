using System.Formats.Asn1;

namespace Variables;
#pragma warning disable CS0219

// TODO 1a: Can I declare a variable here? (yes/no)
// Try it if not sure.
// No
internal class Program
{
    // TODO 1b: Can I declare a variable here? (yes/no)
    // Try it if not sure.
    // No. Mits...

    static void Main()
    {
        // TODO 1c: Can I declare a variable here? (yes/no)
        // Try it if not sure.
        // Yes

        {
            // TODO 1d: Can I declare a variable here? (yes/no)
            // Try it if not sure.
            // Yes
        }

        // TODO  2a: Declare and initialize a variable that stores the number of students.
        // Use Console.WriteLine(variable) to write the value to the screen.
        int numberOfStudents = 10;
        int number_of_students = 10;

        Console.WriteLine(numberOfStudents);

        // TODO  2b: Declare and initialize a variable that stores the grade of a students test.
        // Use Console.WriteLine(variable) to write the value to the screen.
        float grade = 1;
        byte bGrade = 1;
        char cGrade = 'A';

        // TODO  2c: Declare and initialize a variable that stores the name of the student
        // Use Console.WriteLine(variable) to write the value to the screen.
        string nameStudent = "Jan";

        // TODO  2d: Declare and initialize a variable that stores the students average test result.
        // Use Console.WriteLine(variable) to write the value to the screen.
        float averageScore = 7.3F;

        // TODO  2e: Declare and initialize a variable that stores if the student has passed an exam.
        // Use Console.WriteLine(variable) to write the value to the screen.
        bool hasPassed = false;

        // TODO 3a: Find and declare a suitable datatype for positive numbers less or equal to 100
        byte positveNumber = 3;

        // TODO 3b: Find and declare a suitable datatype for numbers less or equal to 10000
        short shortNumber = 10000;

        // TODO 3c: Find and declare a suitable datatype for numbers less or equal to 1_000_000_000
        int getal = 1_000_000_000;
        // TODO 3d: Find and declare a suitable datatype for numbers less or equal to 3_000_000_000
        uint getal2 = 3_000_000_000;

        // TODO 4a: Try to squeeze a variable of type int in a byte. Observe the results
        int numberx = 10000;
        byte nbb = (byte)numberx;

        // TODO 4b: Try to squeeze a variable of type float in an int. Observe the result.
        float floatx = 52.787567F;
        int fnumber = (int)floatx;
        Console.WriteLine(fnumber);
        // TODO  5: What would be the most suitable data type to store the largest possible number PI (3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679)
        // Try a few
        decimal pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679M;
        Console.WriteLine(pi);

        // TODO 6a: Try to convert the following variable into an int.
        string numbers = "123";
        int getal1 = int.Parse(numbers);
        int getal3 = Convert.ToInt32(numbers);

        // TODO 6b: Try to convert the following variable into a float.
        string numberf = "123.456";
        float f1 = float.Parse(numberf);    

        // TODO 6b: Try to convert the following variable into a decimal.
        string numberd = "123.456789456789";
        decimal d1 = decimal.Parse(numberd);

    }

    static void DoSomething()
    {
        // TODO 1e: Can I declare a variable here? (yes/no)
        // Try it if not sure.
        // Yes

    }

    // TODO 1f: Can I declare a variable here? (yes/no)
    // Try it if not sure.
    // No

}

// TODO 1g: Can I declare a variable here? (yes/no)
// Try it if not sure.
// No
