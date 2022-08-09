public class Functions
{
    public int CalculateDaysBetween(DateTime birthday)
    {
        return (int)Math.Ceiling((birthday - DateTime.Now).TotalHours / 24);
    }

    public DateTime GetBirthday()
    {
        Console.WriteLine("When is your birthday?");

        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
        {
            return birthday;
        }
        else
        {
            Console.WriteLine("invalid date");
            return GetBirthday();
        }
    }
}
