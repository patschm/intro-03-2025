namespace Collections;

internal static class Randomizer
{
    public static string RandomName()
    {
        return new Bogus.Faker().Name.FullName();
    }
    public static int RandomInt(int start = 0, int end = int.MaxValue)
    {
        return new Bogus.Faker().Random.Int(start, end);
    }
    public static float RandomFloat(int start = 0, int end = 1)
    {
        return new Bogus.Faker().Random.Float(start, end);
    }
    public static DateTime RandomDate()
    {
        return new Bogus.Faker().Date.Between(DateTime.MinValue, DateTime.MaxValue);
    }
}
