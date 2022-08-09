public class Rechthoek
{
    private int _lengte;
    public int Lengte
    {
        get { return _lengte; }
        set
        {
            if (value >= 1)
            {
                _lengte = value;
            }
        }
    }
    private int _breedte;
    public int Breedte
    {
        get { return _breedte; }
        set
        {
            if (value >= 1)
            {
                _breedte = value;
            }
        }
    }

    public void ToonOppervlakte()
    {
        System.Console.WriteLine($"oppervlakte: {_lengte * _breedte}");
    }
}
