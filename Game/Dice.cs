public class Dice
{
    private readonly Random _random;
    private const int Sides = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1,Sides + 1);  
    }
}
