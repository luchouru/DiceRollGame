public class Game
{
    private readonly Dice _dice;
    private const int Intentos = 3;

    public Game(Dice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        var diceRoll = _dice.Roll();

        Console.WriteLine($"Dado tirado. Adivine el numero en {Intentos} intentos.");

        var intentosRestantes = Intentos;
        while (intentosRestantes > 0)
        {
            var adivinar = ConsoleReader.ReadInteger("Ingresar un numero: ");
            if(adivinar == diceRoll)
            {
                return GameResult.Victoria;
            }
            Console.WriteLine("Numero incorrecto.");
            --intentosRestantes;
        }
        return GameResult.Derrota;
    }
}
