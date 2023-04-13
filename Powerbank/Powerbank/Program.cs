using Powerbank.Klasy;

internal class Program
{
    private static void Main(string[] args)
    {
        Battery Bateria1 = new Battery();
        Console.WriteLine(Bateria1.Summary());
        Battery Bateria2 = new Battery(true, false);
        Console.WriteLine(Bateria2.Summary());
        Battery Bateria3 = new Battery(false, true);
        Console.WriteLine(Bateria3.Summary());
        Battery Bateria4 = new Battery(false, false);
        Console.WriteLine(Bateria4.Summary());
    }
}