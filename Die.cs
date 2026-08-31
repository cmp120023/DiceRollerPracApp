namespace DiceRollerPracApp;

/// <summary>
/// Represents a single die.
/// </summary>
public class Die
{
    /// <summary>
    /// contructs a new instance of die class with specified number of sides.
    /// </summary>
    /// <param name="numSides"></param>
    public Die(byte numSides)
    {
        if(numSides == 0 || numSides > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(numSides), $"{nameof (numSides)} must be greater than 0 and less than 21.");
        }
        NumberOfSides = numSides;
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
        Random rand = new Random();
        FaceUpValue = Convert.ToByte (rand.Next( 1, NumberOfSides + 1 ));

        return FaceUpValue;
    }
}

