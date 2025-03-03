namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        // Declare a variable of type int
        // Datatype variableName;
        int age = 35000; // <== 35 is an integer literal
        bool isMale = true; // <== true is a boolean literal
        double salary = 5000.00; // <== 5000.00 is a double literal
        string name = "Kees"; // <== "Kees" is a string literal

        {
            char prefix = 'M'; // <== 'M' is a char literal
            System.Console.Write(prefix + " ");
        }
        System.Console.WriteLine(name);
        // Constants can't be changed
        const double PI = 3.14159265359;
        System.Console.WriteLine(PI);

        long lage = age; // Implicit conversion
        System.Console.WriteLine(lage);
        short sage = (short)age; // Explicit conversion
        System.Console.WriteLine(sage);

        decimal d = age;
        System.Console.WriteLine(d);
        float f =(float)3.5;
        // Or
        float f2 = 3.5f;

        decimal salaris = 3500.50M;

        string number = "123";
        int inr = int.Parse(number);
        string number2 = age.ToString();
    }
}
