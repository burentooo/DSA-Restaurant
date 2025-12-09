public class ServingService
{
    public int CurrentNumber = 1;

    public int GetNextNumber()
    {
        return CurrentNumber++;
    }
}
