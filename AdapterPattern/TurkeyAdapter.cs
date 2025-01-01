public class TurkeyAdapter : IDuck
{
    private readonly ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public void Quack()
    {
        _turkey.Gobble();
    }

    public void Fly(int times)
    {
        for (var i = 0; i < times; i++)
        {
            PerformTurkeyFlight();
        }
    }

    private void PerformTurkeyFlight()
    {
        _turkey.Fly();
        Console.WriteLine("Resting..");
    }
}
