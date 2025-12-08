public class ServingService
{
    public int CurrentNumber { get; private set; } = 1;

    public int GetNextNumber()
    {
        return CurrentNumber++;
    }
}
