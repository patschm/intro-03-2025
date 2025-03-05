namespace TekstProcessor;

internal class Program
{
    static void Main(string[] args)
    {
        string message = "Russische autoriteiten reageren positief op het nieuws dat Donald Trump een brief van Volodymyr Zelensky heeft gekregen waarin de Oekraïense president aangeeft bereid te zijn om over vrede te onderhandelen. Het Kremlin noemt die ontwikkeling positief. Kremlin-woordvoerder Dmitri Peskov benadrukte wel dat hij niet voor zich ziet hoe vredesgesprekken eruit zouden moeten zien, aangezien Oekraïne volgens hem onderhandelingen met Rusland uitsluit. Hij verwees naar een presidentieel decreet van Zelensky uit 2022 waarin hij onderhandelingen met Vladimir Poetin uitsloot.";

        message = AllFirstWordsToUpper(message);

        Console.WriteLine(message);
    }

    static string AllFirstWordsToUpper(string message)
    {
        string[] words = message.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = FirstLetterToUpper(words[i]);
        }

        return string.Join(" ", words);
    }

    static string FirstLetterToUpper(string s)
    {
        char[] chars = s.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        return new string(chars);
    }

    static bool IsUpper(string s) 
    {
        return char.IsUpper(s[0]);
    }
}
