public class Student
{
    public string Naam { get; set; }
    public int Leeftijd { get; set; }
    public Klassen Klas { get; set; }
    public int PuntenCommunicatie { get; set; }
    public int PuntenProgrammingPrinciples { get; set; }
    public int PuntenWebTech { get; set; }

    private double BerekenTotaalCijfer()
    {
        return Math.Round(
            (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0,
            1
        );
    }

    public void GeefOverzicht()
    {
        System.Console.WriteLine($"{Naam}, {Leeftijd} jaar");
        System.Console.WriteLine($"Klas: {Klas}");
        System.Console.WriteLine();
        System.Console.WriteLine("Cijferrapport:");
        System.Console.WriteLine("***************");
        System.Console.WriteLine();
        System.Console.WriteLine($"Communicatie:\t\t {PuntenCommunicatie}");
        System.Console.WriteLine($"Programming Principles:\t {PuntenProgrammingPrinciples}");
        System.Console.WriteLine($"Web Technology:\t\t {PuntenWebTech}");
        System.Console.WriteLine($"Gemiddelde:\t\t {BerekenTotaalCijfer()}");
    }
}
