namespace DiceRollerPracApp;

/// <summary>
/// Represents a single die.
/// </summary>
public class Die
{
    private const byte MAX_SIDES = 20;
    private readonly static Random rand = new();


    /// <summary>
    /// contructs a new instance of die class with specified number of sides.
    /// </summary>
    /// <param name="numSides"></param>
    public Die(byte numSides)
    {
        if(numSides == 0 || numSides > MAX_SIDES)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), $"{nameof (numSides)} must be greater than 0 and less than 21.");
        }
        NumberOfSides = numSides;


        //Forces die to start as random number.
        Roll();
    }

    /// <summary>
    /// gets the number of sides of die
    /// </summary>
    public byte NumberOfSides {  get; private set; }

    /// <summary>
    /// current face up value for the die
    /// </summary>
    public byte FaceUpValue { get; private set; }

    public byte Roll()
    {
        FaceUpValue = Convert.ToByte (rand.Next( 1, NumberOfSides + 1 ));

        return FaceUpValue;
    }
}

