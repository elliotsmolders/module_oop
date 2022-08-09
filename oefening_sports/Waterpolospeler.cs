public class Waterpolospeler
{
    private string _spelersNaam;
    public string SpelersNaam
    {
        get { return _spelersNaam; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                _spelersNaam = value;
            }
        }
    }
    private int _mutsNummer;
    public int MutsNummer
    {
        get { return _mutsNummer; }
        set
        {
            if (value >= 1 && value <= 13)
            {
                _mutsNummer = value;
            }
        }
    }
    private bool _isDoelman;
    public bool IsDoelman
    {
        get { return _isDoelman; }
        set { _isDoelman = value; }
    }
    private bool _isReserve;
    public bool IsReserve
    {
        get { return _isReserve; }
        set { _isReserve = value; }
    }

    public void StelIn(string naam, int nummer, bool IsDoelman, bool IsReserve)
    {
        SpelersNaam = naam;
        MutsNummer = nummer;
        this.IsDoelman = IsDoelman;
        this.IsReserve = IsReserve;
    }
}
