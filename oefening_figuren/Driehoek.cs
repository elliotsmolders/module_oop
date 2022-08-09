public class Driehoek
{
    private int _basis;
    public int Basis
    {
        get { return _basis; }
        set
        {
            if (value >= 1)
            {
                _basis = value;
            }
        }
    }
    private int _hoogte;
    public int Hoogte
    {
        get { return _hoogte; }
        set
        {
            if (value >= 1)
            {
                _hoogte = value;
            }
        }
    }

    public void ToonOppervlakte()
    {
        System.Console.WriteLine($"oppervlakte: {(_basis * _hoogte) / 2}");
    }
}
