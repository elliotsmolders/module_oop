public class Result
{
    public int Percentage { get; set; }

    private string GetGraad()
    {
        if (Percentage >= 85)
        {
            return "grootste onderscheiding";
        }
        if (Percentage >= 75)
        {
            return "grote onderscheiding";
        }
        if (Percentage >= 68)
        {
            return "onderscheiding";
        }
        if (Percentage >= 50)
        {
            return "voldoende";
        }
        else
        {
            return "niet geslaagd";
        }
    }

    public void PrintGraad()
    {
        System.Console.WriteLine(GetGraad());
    }
}
