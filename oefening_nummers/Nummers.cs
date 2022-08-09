public class Nummers
{
    public int Getal1 { get; set; }
    public int Getal2 { get; set; }

    public int Som()
    {
        return Getal1 + Getal2;
    }

    public int Verschil()
    {
        return Getal1 - Getal2;
    }

    public int Product()
    {
        return Getal1 * Getal2;
    }

    public string Quotient()
    {
        if (Getal1 != 0 && Getal2 != 0)
        {
            return ((double)Getal1 / Getal2).ToString();
        }
        else
        {
            return "Error";
        }
    }
}
